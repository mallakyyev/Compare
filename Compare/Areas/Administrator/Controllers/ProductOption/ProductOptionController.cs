using Compare.BLL.DTOs.ProductOption;
using Compare.BLL.Services.Language;
using Compare.BLL.Services.ProductOption;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compare.Areas.Administrator.Controllers.ProductOption
{
    [Area("Administrator")]
    [Authorize(Roles = "Admin, Directory management")]
    public class ProductOptionController : Controller
    {
        private readonly IProductOptionService _productOptionService;
        private readonly ILanguageService _languageService;

        public ProductOptionController(IProductOptionService productOptionService, ILanguageService languageService)
        {
            _productOptionService = productOptionService;
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
        public async Task<IActionResult> Create(CreateProductOptionDTO value)
        {
            if (ModelState.IsValid)
            {
                await _productOptionService.CreateProductOptionAsync(value);
                return RedirectToAction("Index");
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage();
            return View(value);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var productOptionDTO = await _productOptionService.GetEditProductOptionAsync(id);

            ViewBag.Languages = _languageService.GetAllPublishLanguage();

            return View(productOptionDTO);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditProductOptionDTO value)
        {
            if (ModelState.IsValid)
            {
                await _productOptionService.EditProductOptionAsync(value);
                return RedirectToAction("Index");
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage();
            return View(value);
        }
    }
}
