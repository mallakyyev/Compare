using Compare.BLL.DTOs.Catalog;
using Compare.BLL.Services.Catalog;
using Compare.BLL.Services.Language;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compare.Areas.Administrator.Controllers.Catalog
{
    [Area("Administrator")]
    [Authorize(Roles = "Admin, Directory management")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly ILanguageService _languageService;

        public CategoryController(ICategoryService categoryService, ILanguageService languageService)
        {
            _categoryService = categoryService;
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
        public async Task<IActionResult> Create(CreateCategoryDTO value)
        {
            if (ModelState.IsValid)
            {
                await _categoryService.CreateCategoryAsync(value);
                return RedirectToAction("Index");
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage();
            return View(value);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var category = await _categoryService.GetCategoryAsync(id);

            ViewBag.Languages = _languageService.GetAllPublishLanguage();

            return View(category);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditCategoryDTO value)
        {
            if (ModelState.IsValid)
            {
                await _categoryService.EditCategoryAsync(value);
                return RedirectToAction("Index");
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage();

            return View(value);
        }
    }
}
