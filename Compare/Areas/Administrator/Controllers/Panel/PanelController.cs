using Compare.BLL.DTOs.Panel;
using Compare.BLL.Services.Language;
using Compare.BLL.Services.Panel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compare.Areas.Administrator.Controllers.Panel
{
    [Area("Administrator")]
    [Authorize(Roles = "Admin")]
    public class PanelController : Controller
    {
        private readonly IPanelService _panelService;
        private readonly ILanguageService _languageService;

        public PanelController(IPanelService panelService, ILanguageService languageService)
        {
            _panelService = panelService;
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
        public async Task<IActionResult> Create(CreatePanelDTO value)
        {
            if (ModelState.IsValid)
            {
                await _panelService.CreatePanelAsync(value);
                return RedirectToAction("Index");
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage();
            return View(value);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var panel = await _panelService.GetEditPanelAsync(id);

            ViewBag.Languages = _languageService.GetAllPublishLanguage();

            return View(panel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditPanelDTO value)
        {
            if (ModelState.IsValid)
            {
                await _panelService.EditPanelAsync(value);
                return RedirectToAction("Index");
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage();

            return View(value);
        }
    }
}
