using Compare.BLL.DTOs.Banner;
using Compare.BLL.Services.Banner;
using Compare.BLL.Services.Language;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compare.Areas.Administrator.Controllers.Banner
{
    [Area("Administrator")]
    [Authorize(Roles = "Admin")]
    public class BannerController : Controller
    {
        private readonly IBannerService _bannerService;
        private readonly ILanguageService _languageService;

        public BannerController(IBannerService bannerService, ILanguageService languageService)
        {
            _bannerService = bannerService;
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
        public async Task<IActionResult> Create(CreateBannerDTO value)
        {
            if (ModelState.IsValid)
            {
                await _bannerService.CreateBannerAsync(value);
                return RedirectToAction("Index");
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage();
            return View(value);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var banner = await _bannerService.GetEditBannerAsync(id);

            ViewBag.Languages = _languageService.GetAllPublishLanguage();

            return View(banner);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditBannerDTO value)
        {
            if (ModelState.IsValid)
            {
                await _bannerService.EditBannerAsync(value);
                return RedirectToAction("Index");
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage();
            return View(value);
        }
    }
}
