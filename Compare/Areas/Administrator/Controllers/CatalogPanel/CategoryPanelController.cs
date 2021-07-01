using Compare.BLL.DTOs.CatalogPanel;
using Compare.BLL.Services.CatalogPanel;
using Compare.BLL.Services.Language;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compare.Areas.Administrator.Controllers.CatalogPanel
{
    [Area("Administrator")]
    [Authorize(Roles = "Admin")]
    public class CategoryPanelController : Controller
    {
        private readonly ICategoryPanelService _categoryPanelService;
        private readonly ILanguageService _languageService;

        public CategoryPanelController(ICategoryPanelService categoryPanelService, ILanguageService languageService)
        {
            _categoryPanelService = categoryPanelService;
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
        public async Task<IActionResult> Create(CreateCategoryPanelDTO value)
        {
            if (ModelState.IsValid)
            {
                await _categoryPanelService.CreateCategoryPanelAsync(value);
                return RedirectToAction("Index");
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage();
            return View(value);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var panel = await _categoryPanelService.GetEditCategoryPanelAsync(id);

            ViewBag.Languages = _languageService.GetAllPublishLanguage();

            return View(panel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditCategoryPanelDTO value)
        {
            if (ModelState.IsValid)
            {
                await _categoryPanelService.EditCategoryPanelAsync(value);
                return RedirectToAction("Index");
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage();

            return View(value);
        }
    }
}
