using Compare.BLL.DTOs.ProductAttributeTemplate;
using Compare.BLL.Services.Language;
using Compare.BLL.Services.ProductAttributeTemplate;
using Compare.BLL.Services.ProductOption;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compare.Areas.Administrator.Controllers.ProductAttributeTemplate
{
    [Area("Administrator")]
    [Authorize(Roles = "Admin, Directory management")]
    public class ProductAttributeTemplateController : Controller
    {
        private readonly IProductAttributeTemplateService _productAttributeTemplateService;
        private readonly ILanguageService _languageService;

        public ProductAttributeTemplateController(IProductAttributeTemplateService productAttributeTemplateService,
            ILanguageService languageService)
        {
            _productAttributeTemplateService = productAttributeTemplateService;
            _languageService = languageService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Languages = _languageService.GetAllPublishLanguage();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductAttributeTemplateDTO value)
        {
            if (ModelState.IsValid)
            {
                await _productAttributeTemplateService.CreateProductAttributeTemplateAsync(value);
                return RedirectToAction("Index");
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage();
            return View(value);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var editProductAttributeTemplateDTO = await _productAttributeTemplateService.GetEditProductAttributeTemplateAsync(id);

            ViewBag.Languages = _languageService.GetAllPublishLanguage();

            return View(editProductAttributeTemplateDTO);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditProductAttributeTemplateDTO value)
        {
            if (ModelState.IsValid)
            {
                await _productAttributeTemplateService.EditProductAttributeTemplateAsync(value);
                return RedirectToAction("Index");
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage();

            return View(value);
        }
    }
}
