using Compare.BLL.DTOs.Bookmarks;
using Compare.BLL.DTOs.Commentary.ProductCommentary;
using Compare.BLL.DTOs.Manufacture;
using Compare.BLL.DTOs.Product;
using Compare.BLL.DTOs.ProductDetailAttribute;
using Compare.BLL.Services.Advertising;
using Compare.BLL.Services.Bookmarks;
using Compare.BLL.Services.Catalog;
using Compare.BLL.Services.Manufacture;
using Compare.BLL.Services.Product;
using Compare.BLL.Services.ProductCommentary;
using Compare.DAL.Models.Enums;
using Compare.DAL.Models.User;
using Compare.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compare.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IManufactureService _manufactureService;
        private readonly IAdvertService _advertService;
        private readonly IProductCommentService _productCommentService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IBookmarkService _bookmarkService;

        public ProductController(IProductService productService, ICategoryService categoryService, IManufactureService manufactureService,
            IAdvertService advertService, IProductCommentService productCommentService, UserManager<ApplicationUser> userManager,
            IBookmarkService bookmarkService)
        {
            _productService = productService;
            _categoryService = categoryService;
            _manufactureService = manufactureService;
            _advertService = advertService;
            _productCommentService = productCommentService;
            _userManager = userManager;
            _bookmarkService = bookmarkService;
        }

        public IActionResult Index()
        {
            return View();
        }

        //string[] attributes
        [HttpGet]
        public async Task<IActionResult> ProductCategoryList(int categoryId, int?[] brands, List<SearchAttribute> attributes, int page = 1)
        {
            List<Facet> facets = new List<Facet>();
            var products = _productService.GetProductCategoryList(categoryId);
            var productsAttributes = products.Select(s => s.ProductDetailAttributeList);
            
            foreach (var productDetailAttributeListDTOs in productsAttributes)
            {                
                foreach(var attributeList in productDetailAttributeListDTOs)
                {
                    var attribute = facets.SingleOrDefault(s => s.Name == attributeList.Name);

                    if (attribute == null)
                    {
                        List<ProductDetailAttributeListDTO> productDetailAttributeListDTO = new List<ProductDetailAttributeListDTO>();
                        productDetailAttributeListDTO.Add(new ProductDetailAttributeListDTO
                        {
                            Id = attributeList.Id,
                            Value = attributeList.Value
                        });

                        facets.Add(new Facet
                        {
                            Name = attributeList.Name,
                            AttributeList = productDetailAttributeListDTO
                        });
                    }
                    else
                    {
                        var prA = attribute.AttributeList.SingleOrDefault(s => s.Value == attributeList.Value);
                        if (prA == null)
                        {
                            attribute.AttributeList.Add(new ProductDetailAttributeListDTO
                            {
                                Id = attributeList.Id,
                                Value = attributeList.Value
                            });
                        }
                    }
                }                
            }

            var manufactureIds = products.Select(s => s.ManufactureId).Distinct();
            var manufactures = await _manufactureService.GetManufactureProductsAsync(manufactureIds);

            var adverts = _advertService.GetFilterAdverts(DAL.Models.Enums.PagePlaceStatus.Catalog, categoryId);

            //Поиск по Брэндам
            if (brands != null)
            {
                var brandProducts = new List<ProductDTO>();
                foreach (int brand in brands)
                {
                    brandProducts.AddRange(products.Where(p => p.ManufactureId == brand));
                }
                if (brandProducts.Count > 0)
                {
                    products = brandProducts;
                }
            }

            //Поиск по аттрибутам
            if (attributes != null)
            {
                foreach (var attribute in attributes.ToList())
                {
                    if(attribute.Value != null)
                    {
                        List<ProductDTO> goodsAttributes = new List<ProductDTO>();

                        foreach (var value in attribute.Value)
                        {
                            var prds = products.SelectMany(s => s.ProductDetailAttributeList,
                            (p, a) => new { ProductDTO = p, AttributeList = a })
                            .Where(p => p.AttributeList.Value == value)
                            .Select(s => s.ProductDTO);

                            if (prds != null)
                            {
                                goodsAttributes.AddRange(prds);
                            }
                        }

                        products = goodsAttributes;
                    }
                    else
                    {
                        attributes.Remove(attribute);
                    }
                }
            }

            var countProducts = products.Count();
            var items = products.Skip((page - 1) * 30).Take(30);

            PageViewModel pageViewModel = new PageViewModel(countProducts, page, 30);
            var categoryDTO = await _categoryService.GetCategoryDTOAsync(categoryId);
            ProductViewModel productViewModel = new ProductViewModel
            {
                ProductDTOs = items,
                PageViewModel = pageViewModel,
                FilterProductList = new FilterProductList()
                {
                    CategoryId = categoryId,
                    CategoryName = categoryDTO.Name,
                    MetaTitle = categoryDTO.MetaTitle,
                    MetaDescription = categoryDTO.MetaDescription,
                    Brands = brands,
                    Manufactures = manufactures,
                    Attributes = attributes,
                    FacetList = facets
                },
                AdvertList = adverts
            };

            return View(productViewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int productId, string alert_message)
        {
            ViewBag.AlertMessage = alert_message;
            var user = await _userManager.GetUserAsync(User);
            var product = await _productService.ProductDetailAsync(productId, user?.Id);
            return View(product);
        }

        [HttpGet]
        public IActionResult Search(string text, int page = 1)
        {
            var products = _productService.GetSearchProducts(text);
            var countProducts = products.Count();
            var items = products.Skip((page - 1) * 30).Take(30);

            PageViewModel pageViewModel = new PageViewModel(countProducts, page, 30);
            ProductViewModel productViewModel = new ProductViewModel
            {
                ProductDTOs = items,
                PageViewModel = pageViewModel,
                SearchText = text
            };

            return View(productViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> SendComment(ProductCommentCreateDto model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var user = await _userManager.GetUserAsync(User);
                    model.ApplicationUserId = user.Id;
                    await _productCommentService.CreateProductCommentAsync(model);

                    return RedirectToAction("Detail", new { productId = model.ProductId, alert_message = "success" });
                }

                return RedirectToAction("Detail", new { productId = model.ProductId, alert_message = "danger" });
            }
            catch(Exception ex)
            {
                return RedirectToAction("Detail", new { productId = model.ProductId, alert_message = "danger" });
            }            
        }

        [HttpPost]
        public async Task<IActionResult> AddBookmark(BookmarkCreateDto bookmarkCreateDto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var user = await _userManager.GetUserAsync(User);
                    bookmarkCreateDto.ApplicationUserId = user.Id;

                    var response = await _bookmarkService.CreateBookmarkAsync(bookmarkCreateDto);

                    if(response == ModelStatus.Success)
                    {
                        return RedirectToAction("Detail", new { productId = bookmarkCreateDto.ProductId, alert_message = "success_bookmark" });
                    }
                    else if(response == ModelStatus.Duplicate)
                    {
                        return RedirectToAction("Detail", new { productId = bookmarkCreateDto.ProductId, alert_message = "duplicate_bookmark" });
                    }
                    else
                    {
                        return RedirectToAction("Detail", new { productId = bookmarkCreateDto.ProductId, alert_message = "danger_bookmark" });
                    }
                    
                }
                return RedirectToAction("Detail", new { productId = bookmarkCreateDto.ProductId, alert_message = "danger_bookmark" });
            }
            catch (Exception ex)
            {
                return RedirectToAction("Detail", new { productId = bookmarkCreateDto.ProductId, alert_message = "danger_bookmark" });
            }
        }
    }
}
