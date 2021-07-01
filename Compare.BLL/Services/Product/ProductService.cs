using AutoMapper;
using Compare.BLL.DTOs.Product;
using Compare.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Http;
using Compare.DAL.Models.Catalog;
using product = Compare.DAL.Models.Catalog;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using Compare.BLL.Services.Organization;
using System.Text.Json;
using System.Net.Http;
using Compare.BLL.DTOs.Partnership;
using Compare.BLL.DTOs.Organization;
using System.Linq.Expressions;
using Compare.BLL.DTOs.ProductDetailAttribute;
using Compare.BLL.Services.OrganizationSubscription;
using Compare.BLL.Services.ProductDetailAttribute;
using Compare.BLL.DTOs.Commentary.ProductCommentary;
using Microsoft.AspNetCore.Identity;
using Compare.DAL.Models.User;

namespace Compare.BLL.Services.Product
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IHostingEnvironment _appEnvironment;
        private readonly IOrganizationSubscriptionService _organizationSubscriptionService;
        private readonly IProductDetailAttributeService _productDetailAttributeService;        

        public ProductService(ApplicationDbContext dbContext, IMapper mapper, IHostingEnvironment appEnvironment,
            IOrganizationSubscriptionService organizationSubscriptionService,
            IProductDetailAttributeService productDetailAttributeService)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _appEnvironment = appEnvironment;
            _organizationSubscriptionService = organizationSubscriptionService;
            _productDetailAttributeService = productDetailAttributeService;
        }

        public async Task CreateProductAsync(CreateProductDTO modelDTO)
        {
            List<CategoryAndProduct> categoriesAndProducts = new List<CategoryAndProduct>();
            List<ProductMedia> productMedias = new List<ProductMedia>();

            product.Product prd = _mapper.Map<product.Product>(modelDTO);
            foreach (int catId in modelDTO.CategoriesId)
            {
                categoriesAndProducts.Add(new CategoryAndProduct()
                {
                    CategoryId = catId,
                    ProductId = prd.Id
                });
            }
            prd.CategoriesAndProducts = categoriesAndProducts;

            if (modelDTO.FormFile != null)
            {
                string fileName = await ImageService.UploadImage(modelDTO.FormFile, "/images/products/L/", _appEnvironment);
                prd.Image = fileName;
            }
            if (modelDTO.FormFiles != null)
            {
                foreach (var file in modelDTO.FormFiles)
                {
                    string fileName = await ImageService.UploadImage(file, "/images/products/L/", _appEnvironment);
                    productMedias.Add(new ProductMedia()
                    {
                        ProductId = prd.Id,
                        Image = fileName
                    });
                }
                prd.ProductMedias = productMedias;
            }

            await _dbContext.Products.AddAsync(prd);
            await _dbContext.SaveChangesAsync();

            if (modelDTO.ProductIdAttribute != null)
            {
                await _productDetailAttributeService.FindProductDetailAttributeAndCreateCopyAsync((int)modelDTO.ProductIdAttribute, prd.Id);
            }
        }

        public async Task CreateCopyProductAsync(CreateProductDTO modelDTO)
        {
            await CreateProductAsync(modelDTO);
        }

        public async Task EditProductAsync(EditProductDTO modelDTO)
        {
            List<ProductMedia> productMedias = new List<ProductMedia>();

            var product = await _dbContext.Products.Include(p => p.CategoriesAndProducts).AsSplitQuery()
                .Include(p => p.ProductTranslates).AsSplitQuery()
                .FirstOrDefaultAsync(p => p.Id == modelDTO.Id);

            product.ProductTranslates.Clear();
            product.CategoriesAndProducts.Clear();

            product.ProductTranslates = modelDTO.ProductTranslates
                .Select(p => new ProductTranslate
                {
                    LanguageCulture = p.LanguageCulture,
                    ProductId = p.ProductId,
                    ProductName = p.ProductName,
                    ShortDescription = p.ShortDescription,
                    FullDescription = p.FullDescription,
                    MetaDescription = p.MetaDescription,
                    MetaTitle = p.MetaTitle
                }).ToList();

            product.CategoriesAndProducts = modelDTO.CategoriesId
                .Select(p => new CategoryAndProduct
                {
                    ProductId = product.Id,
                    CategoryId = p
                }).ToList();

            product.ManufactureId = modelDTO.ManufactureId;
            product.Published = modelDTO.Published;
            product.DisplayOrder = modelDTO.DisplayOrder;

            if (modelDTO.FormFile != null)
            {
                ImageService.DeleteImage(product.Image, "/images/products/L/", _appEnvironment);

                string fileName = await ImageService.UploadImage(modelDTO.FormFile, "/images/products/L/", _appEnvironment);
                product.Image = fileName;
            }
            if (modelDTO.FormFiles != null)
            {
                foreach (var file in modelDTO.FormFiles)
                {
                    string fileName = await ImageService.UploadImage(file, "/images/products/L/", _appEnvironment);
                    productMedias.Add(new ProductMedia()
                    {
                        ProductId = product.Id,
                        Image = fileName
                    });
                }
                product.ProductMedias = productMedias;
            }

            _dbContext.Update(product);
            await _dbContext.SaveChangesAsync();
        }

        public IEnumerable<ProductDTO> GetAllProducts()
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var products = _dbContext.Products
                .Include(i => i.Manufacture).AsQueryable();
            var result = _dbContext.ProductTranslates
                .Where(p => p.LanguageCulture == culture).Join(products, p => p.ProductId, k => k.Id,
                (p, k) => new ProductDTO
                {
                    Id = k.Id,
                    ProductName = p.ProductName,
                    ShortDescription = p.ShortDescription,
                    FullDescription = p.FullDescription,
                    Published = k.Published,
                    ManufactureName = k.Manufacture.Name,
                    Image = k.Image,
                    DisplayOrder = k.DisplayOrder,
                    ProductDetailAttributeId = k.ProductDetailAttributeId
                });
            return result;
        }

        public async Task<EditProductDTO> GetProductAsync(int id)
        {
            product.Product prd = await _dbContext.Products
                .Include(i => i.ProductTranslates).AsSplitQuery()
                .Include(i => i.CategoriesAndProducts).AsSplitQuery()
                .SingleOrDefaultAsync(s => s.Id == id);
            EditProductDTO productDTO = _mapper.Map<EditProductDTO>(prd);
            return productDTO;
        }

        public async Task RemoveProductAsync(int id)
        {
            product.Product prd = await _dbContext.Products.FindAsync(id);
            var imagesProduct = _dbContext.ProductMedias.Where(p => p.ProductId == id);
            if (!string.IsNullOrEmpty(prd.Image))
            {
                ImageService.DeleteImage(prd.Image, "/images/products/L/", _appEnvironment);
            }
            foreach (var img in imagesProduct)
            {
                ImageService.DeleteImage(img.Image, "/images/products/L/", _appEnvironment);
            }
            _dbContext.Products.Remove(prd);
            await _dbContext.SaveChangesAsync();
        }

        public IEnumerable<ProductDTO> GetProductCategoryList(int categoryId)
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            try
            {
                List<ProductDTO> productDTOs = new List<ProductDTO>();

                var catProd = _dbContext.CategoriesAndProducts
                    .Include(i => i.Product).ThenInclude(t => t.ProductTranslates).AsSplitQuery()
                    .Include(i => i.Product).ThenInclude(t => t.ProductDetailAttribute).ThenInclude(t => t.ProductDetailAttributeTranslates).AsSplitQuery()
                    .Where(p => p.CategoryId == categoryId && p.Product.Published == true)
                    .Select(s => s.Product);

                //var products = _dbContext.Products
                //    .Where(p => p.Published == true)
                //    .Include(i => i.CategoriesAndProducts.Where(p => p.CategoryId == categoryId)).AsSplitQuery()
                //    .Include(i => i.ProductTranslates).AsSplitQuery()
                //    .Include(i => i.ProductDetailAttribute).ThenInclude(t => t.ProductDetailAttributeTranslates).AsSplitQuery();
                //.Join(catProd, p => p.Id, cp => cp.ProductId, (p, cp)
                //=> new ProductDTO
                //{
                //    Id = p.Id,
                //    ProductName = p.ProductTranslates.SingleOrDefault(s => s.LanguageCulture == culture).ProductName,
                //    ShortDescription = p.ProductTranslates.SingleOrDefault(s => s.LanguageCulture == culture).ShortDescription,
                //    FullDescription = p.ProductTranslates.SingleOrDefault(s => s.LanguageCulture == culture).FullDescription,
                //    Image = p.Image,
                //    DisplayOrder = p.DisplayOrder,
                //    MinPrice = p.MinPrice,
                //    MaxPrice = p.MaxPrice,
                //    ManufactureId = p.ManufactureId,
                //    CountOffers = p.CountOffers
                //});

                foreach (var product in catProd)
                {
                    var productDto = new ProductDTO();

                    productDto.Id = product.Id;
                    productDto.ProductName = product.ProductTranslates.SingleOrDefault(s => s.LanguageCulture == culture).ProductName;
                    productDto.ShortDescription = product.ProductTranslates.SingleOrDefault(s => s.LanguageCulture == culture).ShortDescription;
                    productDto.Image = product.Image;
                    productDto.DisplayOrder = product.DisplayOrder;
                    productDto.MinPrice = product.MinPrice;
                    productDto.MaxPrice = product.MaxPrice;
                    productDto.CountOffers = product.CountOffers;
                    productDto.ManufactureId = product.ManufactureId;
                    productDto.ProductDetailAttributeList = new List<ProductDetailAttributeListDTO>();
                    if (product.ProductDetailAttribute != null)
                    {
                        foreach (var productAttribute in product.ProductDetailAttribute.ProductDetailAttributeTranslates
                        .Where(p => p.LanguageCulture == culture))
                        {
                            productDto.ProductDetailAttributeList.Add(new ProductDetailAttributeListDTO
                            {
                                Id = productAttribute.Id,
                                Name = productAttribute.Name,
                                Value = productAttribute.Value
                            });
                        }
                    }

                    productDTOs.Add(productDto);
                }

                return productDTOs;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<ProductDTO> ProductDetailAsync(int productId, string userId)
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            ProductDTO productDTO = new ProductDTO();
            var product = await _dbContext.Products
                .Include(i => i.Manufacture).AsSplitQuery()
                .Include(i => i.ProductTranslates).AsSplitQuery()
                .Include(i => i.ProductMedias).AsSplitQuery()
                .Include(i => i.OrganizationProducts).AsSplitQuery()
                .Include(i => i.ProductDetailAttribute).ThenInclude(t => t.ProductDetailAttributeTranslates).AsSplitQuery()
                .Include(i => i.ProductComments.Where(p => p.IsPublish == true)).AsSplitQuery()
                .SingleOrDefaultAsync(s => s.Id == productId && s.Published == true);
            if (product != null)
            {
                productDTO.Id = product.Id;
                productDTO.ProductName = product.ProductTranslates.SingleOrDefault(s => s.LanguageCulture == culture).ProductName;
                productDTO.MetaTitle = product.ProductTranslates.SingleOrDefault(s => s.LanguageCulture == culture).MetaTitle;
                productDTO.MetaDescription = product.ProductTranslates.SingleOrDefault(s => s.LanguageCulture == culture).MetaDescription;
                productDTO.Image = product.Image;
                productDTO.ShortDescription = product.ProductTranslates.SingleOrDefault(s => s.LanguageCulture == culture).ShortDescription;
                productDTO.FullDescription = product.ProductTranslates.SingleOrDefault(s => s.LanguageCulture == culture).FullDescription;
                productDTO.ManufactureName = product.Manufacture.Name;

                productDTO.OrganizationProducts = new List<OrganizationProductDTO>();
                productDTO.ProductMedias = new List<ProductMediaDTO>();
                productDTO.ProductDetailAttributeList = new List<ProductDetailAttributeListDTO>();
                foreach (var orgProd in product.OrganizationProducts)
                {
                    var orgSub = await _dbContext.OrganizationSubscriptions.Include(i => i.Organization).AsSplitQuery()
                        .SingleOrDefaultAsync(s => s.OrganizationId == orgProd.OrganizationId && s.ExpireAt >= DateTime.Now.Date);
                    if (orgSub != null)
                    {
                        var orgProdDTO = new OrganizationProductDTO();
                        orgProdDTO.Id = orgProd.Id;
                        orgProdDTO.InStock = orgProd.InStock;
                        orgProdDTO.OfficialDealer = orgProd.OfficialDealer;
                        orgProdDTO.OrganizationId = orgProd.OrganizationId;
                        orgProdDTO.OrganizationProductUrl = orgProd.OrganizationProductUrl;
                        orgProdDTO.Price = orgProd.Price;
                        orgProdDTO.Organization = new OrganizationDTO()
                        {
                            Id = orgSub.Organization.Id,
                            Name = orgSub.Organization.Name,
                            Logo = orgSub.Organization.Logo,
                            Phone = orgSub.Organization.Phone,
                            Site = orgSub.Organization.Site,
                            Email = orgSub.Organization.Email,
                            Address = orgSub.Organization.Address,
                            Description = orgSub.Organization.Description
                        };

                        productDTO.OrganizationProducts.Add(orgProdDTO);
                    }
                }
                productDTO.ProductComments = new List<ProductCommentListDto>();
                foreach (var productComment in product.ProductComments)
                {
                    productDTO.ProductComments.Add(new ProductCommentListDto()
                    {
                        Id = productComment.Id,
                        Name = productComment.Name,
                        Description = productComment.Description,
                        PublicateDate = productComment.PublicateDate,
                        IsPublish = productComment.IsPublish
                    });
                }
                productDTO.MinPrice = product.MinPrice;
                productDTO.MaxPrice = product.MaxPrice;
                productDTO.CountOffers = product.CountOffers;
                if (userId != null)
                {
                    var bookmark = await _dbContext.Bookmarks
                        .SingleOrDefaultAsync(s => s.ApplicationUserId == userId && s.ProductId == product.Id);
                    if (bookmark != null)
                    {
                        productDTO.InBookmark = true;
                    }
                }

                foreach (var media in product.ProductMedias)
                {
                    productDTO.ProductMedias.Add(new ProductMediaDTO()
                    {
                        Id = media.Id,
                        Image = media.Image
                    });
                }
                var atrb = product.ProductDetailAttribute;
                if (atrb != null)
                {
                    foreach (var attribute in atrb.ProductDetailAttributeTranslates.Where(s => s.LanguageCulture == culture))
                    {
                        productDTO.ProductDetailAttributeList.Add(new ProductDetailAttributeListDTO()
                        {
                            Name = attribute.Name,
                            Value = attribute.Value
                        });
                    }
                }
            }

            return productDTO;
        }

        public IEnumerable<ProductDTO> GetSearchProducts(string text)
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            try
            {
                List<ProductDTO> productDTOs = new List<ProductDTO>();

                var products = _dbContext.ProductTranslates
                    .Where(p => p.ProductName.ToLower().Contains(text.ToLower()))
                    .Include(i => i.Product).AsSplitQuery();

                if (products != null)
                {
                    foreach (var product in products.Where(p => p.LanguageCulture == culture))
                    {
                        productDTOs.Add(new ProductDTO()
                        {
                            Id = product.ProductId,
                            ProductName = product.ProductName,
                            ShortDescription = product.ShortDescription,
                            FullDescription = product.FullDescription,
                            Image = product.Product.Image,
                            DisplayOrder = product.Product.DisplayOrder,
                            MinPrice = product.Product.MinPrice,
                            MaxPrice = product.Product.MaxPrice,
                            ManufactureId = product.Product.ManufactureId,
                            CountOffers = product.Product.CountOffers
                        });
                    }
                }

                return productDTOs;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public IEnumerable<ProductMediaDTO> GetProductMedias(int productId)
        {
            var productPictures = _dbContext.ProductMedias.Where(p => p.ProductId == productId);

            var productMedias = _mapper.Map<IEnumerable<ProductMediaDTO>>(productPictures);

            return productMedias;
        }

        public async Task RemoveProductMediaAsync(int id)
        {
            var media = await _dbContext.ProductMedias.FindAsync(id);

            _dbContext.ProductMedias.Remove(media);
            await _dbContext.SaveChangesAsync();
        }

        public IEnumerable<ProductDTO> GetAllProductsOrganizationSubscription(int organizationId)
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            List<ProductDTO> productDTOs = new List<ProductDTO>();
            var organizationSubscriptionDTOs = _organizationSubscriptionService.GetAllCategoryOrganizationSubscription(organizationId).AsQueryable();

            try
            {
                foreach (var orgSubscription in organizationSubscriptionDTOs)
                {
                    var catProd = _dbContext.CategoriesAndProducts
                    .Where(p => p.CategoryId == orgSubscription.CategoryId);

                    var products = _dbContext.Products
                        .Include(i => i.ProductTranslates).AsSplitQuery()
                        .Include(i => i.OrganizationProducts).AsSplitQuery()
                        .Where(p => p.Published == true)
                        .Join(catProd, p => p.Id, cp => cp.ProductId, (p, cp)
                        => new ProductDTO
                        {
                            Id = p.Id,
                            ProductName = p.ProductTranslates.SingleOrDefault(s => s.LanguageCulture == culture).ProductName
                        });

                    foreach (var product in products)
                    {
                        var orgProdPrice = _dbContext.OrganizationProducts.FirstOrDefault(s => s.OrganizationId == organizationId
                        && s.ProductId == product.Id);
                        if (orgProdPrice == null)
                        {
                            productDTOs.Add(product);
                        }
                    }

                    //productDTOs.AddRange(products);
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return productDTOs;
        }
    }
}
