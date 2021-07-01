using Compare.BLL.DTOs.ProductDetailAttribute;
using Compare.BLL.Services.Language;
using Compare.BLL.Services.ProductAttributeTemplate;
using Compare.BLL.Services.ProductDetailAttribute;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compare.Areas.Administrator.Controllers.ProductDetailAttribute
{
    [Area("Administrator")]
    [Authorize(Roles = "Admin, Directory management")]
    public class ProductDetailAttributeController : Controller
    {
        private readonly IProductAttributeTemplateService _productAttributeTemplateService;
        private readonly IProductDetailAttributeService _productDetailAttributeService;
        private readonly ILanguageService _languageService;

        public ProductDetailAttributeController(IProductAttributeTemplateService productAttributeTemplateService, 
            IProductDetailAttributeService productDetailAttributeService, ILanguageService languageService)
        {
            _productAttributeTemplateService = productAttributeTemplateService;
            _productDetailAttributeService = productDetailAttributeService;
            _languageService = languageService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Check(int productId, int? productAttributeTemplateId)
        {
            if(productAttributeTemplateId != null && productAttributeTemplateId != 0)
            {
                return RedirectToAction("Edit", new { productId = productId });
            }
            else
            {
                return RedirectToAction("Create", new { productId = productId });
            }
        }

        [HttpGet]
        public IActionResult Create(int productId)
        {
            ViewBag.ProductId = productId;
            ViewBag.Languages = _languageService.GetAllPublishLanguage();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductDetailAttributeDTO value)
        {
            if (ModelState.IsValid)
            {
                await _productDetailAttributeService.CreateProductDetailAttributeAsync(value);
                return RedirectToAction("Index","Product");
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage();
            return View(value);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int productId)
        {
            var editProductDetailAttributeDTO = await _productDetailAttributeService.GetEditProductDetailAttributeAsync(productId);

            ViewBag.Languages = _languageService.GetAllPublishLanguage();

            return View(editProductDetailAttributeDTO);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditProductDetailAttributeDTO value)
        {
            if (ModelState.IsValid)
            {
                await _productDetailAttributeService.EditProductDetailAttributeAsync(value);
                return RedirectToAction("Index", "Product");
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage();
            return View(value);
        }
    }
}
