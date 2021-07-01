using Compare.BLL.DTOs.Advertising;
using Compare.BLL.Services.Advertising;
using Compare.BLL.Services.Language;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compare.Areas.Administrator.Controllers.Advert
{
    [Area("Administrator")]
    [Authorize(Roles = "Admin")]
    public class AdvertController : Controller
    {
        private readonly IAdvertService _advertService;
        private readonly ILanguageService _languageService;

        public AdvertController(IAdvertService advertService, ILanguageService languageService)
        {
            _advertService = advertService;
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
        public async Task<IActionResult> Create(CreateAdvertDTO value)
        {
            if (ModelState.IsValid)
            {
                await _advertService.CreateAdvertAsync(value);
                return RedirectToAction("Index");
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage();
            return View(value);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var editAdvertDTO = await _advertService.GetEditAdvertAsync(id);

            ViewBag.Languages = _languageService.GetAllPublishLanguage();

            return View(editAdvertDTO);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditAdvertDTO value)
        {
            if (ModelState.IsValid)
            {
                await _advertService.EditAdvertAsync(value);
                return RedirectToAction("Index");
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage();
            return View(value);
        }
    }
}
