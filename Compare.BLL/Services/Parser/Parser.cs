using AutoMapper;
using Compare.BLL.DTOs.Product;
using Compare.BLL.Services.Checking;
using Compare.BLL.Services.Organization;
using Compare.BLL.Services.Product;
using Compare.DAL.Data;
using Compare.DAL.Models.OnlineMarkets;
using HtmlAgilityPack;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Serilog;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.Services.Parser
{
    public class Parser : IParser
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly ICheckingService _checkingService;
        private readonly IProductService _productService;
        private readonly IOrganizationService _organizationService;
        private readonly IHostingEnvironment _appEnvironment;
        private readonly IMapper _mapper;

        public Parser(ApplicationDbContext dbContext, ICheckingService checkingService, IProductService productService,
            IOrganizationService organizationService, IHostingEnvironment appEnvironment, IMapper mapper)
        {
            _dbContext = dbContext;
            _checkingService = checkingService;
            _productService = productService;
            _organizationService = organizationService;
            _appEnvironment = appEnvironment;
            _mapper = mapper;
        }

        public async Task ParserOrganizationProductPriceAsync()
        {
            try
            {
                string[] onlineMarkets = { "ynamdar.com" };

                foreach (string onlineMarket in onlineMarkets)
                {
                    var products = _dbContext.OrganizationProducts
                    .Where(p => p.OrganizationProductUrl.ToLower().Contains(onlineMarket.ToLower()));

                    foreach (var product in products)
                    {
                        try
                        {
                            double price = 0;

                            var response = CallUrl(product.OrganizationProductUrl).Result;

                            if (onlineMarket == "gipertm.com")
                            {
                                //price = ParseHtmlPriceGiper(response);
                            }
                            else if (onlineMarket == "ynamdar.com")
                            {
                                price = ParseHtmlPriceYnamdar(response);
                            }

                            if (price > 0)
                            {
                                product.Price = price;
                                product.InStock = true;
                            }
                            else
                            {
                                product.InStock = false;
                            }
                            _dbContext.OrganizationProducts.Update(product);
                            await _dbContext.SaveChangesAsync();

                            await _checkingService.CheckMinMaxPriceProductById(product.ProductId);

                            Log.Information($"Success: Update {onlineMarket} - product id {product.ProductId}");
                        }
                        catch (Exception ex)
                        {
                            Log.Information($"Error: ({onlineMarket}-{product.OrganizationProductUrl}) - {ex.Message}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        /// <summary>
        /// 100Haryt.com парсер цен
        /// </summary>
        /// <returns></returns>
        public async Task ParserYuzharytProductPriceAsync()
        {
            try
            {
                //Id 6 - это в сервере id организации
                var products = _dbContext.OrganizationProducts
                    .Where(p => p.OrganizationId == 6 && p.OrganizationProductId > 0);

                foreach (var product in products)
                {
                    using (var httpClientHandler = new HttpClientHandler())
                    {
                        httpClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; };
                        using (HttpClient client = new HttpClient(httpClientHandler))
                        {
                            var response = await client.GetAsync($"https://api.yuzharyt.com/api/product_show/{product.OrganizationProductId}");
                            Log.Information("Info response " + JsonConvert.SerializeObject(response));
                            if (response.IsSuccessStatusCode)
                            {
                                var content = await response.Content.ReadAsStringAsync();
                                var obj = JsonConvert.DeserializeObject<Yuzharyt>(content);
                                if (obj != null)
                                {
                                    product.Price = obj.p_price_1;
                                    product.InStock = true;
                                }
                                else
                                {
                                    product.InStock = false;
                                }
                                _dbContext.OrganizationProducts.Update(product);
                                await _dbContext.SaveChangesAsync();

                                await _checkingService.CheckMinMaxPriceProductById(product.ProductId);
                                Log.Information($"Success: Update api.yuzharyt.com/api/product_show/{product.OrganizationProductId}");
                            }
                            else
                            {
                                Log.Error($"Error: Dont Update api.yuzharyt.com/api/product_show/{product.OrganizationProductId}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, "api.yuzharyt.com/api/product_show/{product.OrganizationProductId}");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        public async Task ProductPriceCheckAsync()
        {
            try
            {
                var products = _dbContext.Products.Where(p => p.Published == true);

                foreach (var product in products)
                {
                    await _checkingService.CheckMinMaxPriceProductById(product.Id);

                    //var organizationProducts = await _dbContext.OrganizationProducts
                    //    .Include(i => i.Organization)
                    //    .ThenInclude(t => t.OrganizationSubscriptions.Where(p => p.PaymentDate <= DateTime.Now.Date && p.ExpireAt >= DateTime.Now.Date)).AsSplitQuery()
                    //    .Where(p => p.ProductId == product.Id).ToListAsync();

                    //if (organizationProducts.Count > 0)
                    //{

                    //    product.MinPrice = organizationProducts.Min(p => p.Price);
                    //    product.MaxPrice = organizationProducts.Max(p => p.Price);
                    //    product.CountOffers = organizationProducts.Count();
                    //}
                    //else
                    //{
                    //    product.MinPrice = 0;
                    //    product.MaxPrice = 0;
                    //    product.CountOffers = 0;
                    //}

                    //_dbContext.Products.Update(product);
                    //await _dbContext.SaveChangesAsync();

                    Log.Information($"Success: Update product price check: productId = {product.Id}");
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, "Error: ProductPriceCheckAsync");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }





        //Methods
        private static async Task<string> CallUrl(string fullUrl)
        {
            HttpClient client = new HttpClient();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls13;
            client.DefaultRequestHeaders.Accept.Clear();
            var response = client.GetStringAsync(fullUrl);
            return await response;
        }

        private double ParseHtmlPriceGiper(string html)
        {
            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);
            var programmerLinks = htmlDoc.DocumentNode.SelectSingleNode("//div[@class='price']");
            if (programmerLinks != null)
            {
                var child = programmerLinks.ChildNodes.FirstOrDefault(f => f.Name == "span");
                var priceReplace = child.InnerText.Replace("ТМТ", "");
                double price = Double.Parse(priceReplace, CultureInfo.InvariantCulture);

                return price;
            }
            else
            {
                return 0;
            }
        }

        private double ParseHtmlPriceYnamdar(string html)
        {
            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);
            string priceReplace = null;

            var notInStock = htmlDoc.DocumentNode.SelectSingleNode("//h4[@class='text-danger']");
            if (notInStock == null)
            {
                var programmerLinks = htmlDoc.DocumentNode.SelectSingleNode("//div[@class='product-price fixed']");
                if (programmerLinks != null)
                {
                    var child = programmerLinks.ChildNodes.FirstOrDefault(f => f.Name == "span");
                    if (child != null)
                    {
                        priceReplace = child.InnerText.Replace("манат", "").Replace(" ", "");
                    }
                    else
                    {
                        priceReplace = programmerLinks.InnerText.Replace("\n", "").Replace("манат", "").Replace(" ", "");
                    }
                    double price = Double.Parse(priceReplace, CultureInfo.InvariantCulture);

                    return price;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }


        }

        //public async Task ParserYuzharytProductAsync()
        //{
        //    try
        //    {
        //        // Удаление дубликатов
        //        var products = _productService.GetAllProducts();
        //        var prodGs = products.OrderBy(o => o.Id).GroupBy(g => g.ProductName)
        //            .Where(p => p.Count() > 1).SelectMany(s => s.Skip(1)).ToList();
        //        if(prodGs.Count() > 0)
        //        {
        //            var prds = _mapper.Map<IEnumerable<Compare.DAL.Models.Catalog.Product>>(prodGs);
        //            foreach(var p in prds)
        //            {
        //                ImageService.DeleteImage(p.Image, "/images/products/L/", _appEnvironment);
        //            }
        //            _dbContext.Products.RemoveRange(prds);
        //            await _dbContext.SaveChangesAsync();
        //        }

        //        var organizationApis = _organizationService.GetOrganizationApiList();
        //        foreach(var organizationApi in organizationApis)
        //        {
        //            using (var httpClientHandler = new HttpClientHandler())
        //            {
        //                httpClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; };
        //                using (HttpClient client = new HttpClient(httpClientHandler))
        //                {
        //                    var response = await client.GetAsync(organizationApi.UrlApi);
        //                    if (response.IsSuccessStatusCode)
        //                    {
        //                        var content = await response.Content.ReadAsStringAsync();
        //                        var objs = JsonConvert.DeserializeObject<Data>(content);

        //                        foreach (var obj in objs.data.rows)
        //                        {
        //                            var product = _productService.GetSearchProducts(obj.p_name_ru);
        //                            if (product.Count() == 0)
        //                            {
        //                                List<ProductTranslateDTO> productTranslateDTOs = new List<ProductTranslateDTO>();
        //                                CreateProductDTO createProductDTO = new CreateProductDTO();

        //                                if(obj.p_img != null)
        //                                {
        //                                    using (WebClient webClient = new WebClient())
        //                                    {
        //                                        var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(obj.p_name_ru) + ".jpeg";

        //                                        webClient.DownloadFileAsync(new Uri($"https://api.yuzharyt.com/img/products/{obj.p_img}"), _appEnvironment.WebRootPath + "/images/products/L/" + fileName);
        //                                        createProductDTO.Image = fileName;
        //                                    }
        //                                }
                                        

        //                                productTranslateDTOs.Add(new ProductTranslateDTO()
        //                                {
        //                                    ProductName = obj.p_name_ru,
        //                                    MetaTitle = $"Купить {obj.p_name_ru} в Ашхабаде",
        //                                    MetaDescription = $"Купить {obj.p_name_ru}",
        //                                    ShortDescription = obj.p_name_ru,
        //                                    FullDescription = obj.p_name_ru,
        //                                    LanguageCulture = "ru"
        //                                });
        //                                productTranslateDTOs.Add(new ProductTranslateDTO()
        //                                {
        //                                    ProductName = obj.p_name_ru,
        //                                    MetaTitle = $"Купить {obj.p_name_ru} в Ашхабаде",
        //                                    MetaDescription = $"Купить {obj.p_name_ru}",
        //                                    ShortDescription = obj.p_name_ru,
        //                                    FullDescription = obj.p_name_ru,
        //                                    LanguageCulture = "tk"
        //                                });
        //                                createProductDTO.ProductTranslates = productTranslateDTOs;
        //                                createProductDTO.CategoriesId = (int[])organizationApi.CategoriesAndOrganizationApis.Select(s => s.CategoryId).ToArray();
        //                                createProductDTO.ManufactureId = 18;
        //                                createProductDTO.Published = true;
        //                                createProductDTO.DisplayOrder = 500;

        //                                await _productService.CreateProductAsync(createProductDTO);
        //                                Log.Information($"Success parser product {obj.p_name_ru}");
        //                            }
        //                        }
        //                    }
        //                    else
        //                    {
        //                        Log.Error($"Error: Dont parser product");
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Log.Error(ex.Message, "ParserYuzharytProductAsync");
        //    }
        //    finally
        //    {
        //        Log.CloseAndFlush();
        //    }
        //}
    }
}
