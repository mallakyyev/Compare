using Compare.BLL.DTOs.Info;
using Compare.BLL.Services.Info;
using Compare.BLL.Services.Language;
using Compare.DAL.Models.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compare.Areas.Administrator.Controllers.Information
{
    [Area("Administrator")]
    [Authorize(Roles = "Admin")]
    public class InformationController : Controller
    {
        private readonly IInformationService _informationService;
        private readonly ILanguageService _languageService;

        public InformationController(IInformationService informationService, ILanguageService languageService)
        {
            _informationService = informationService;
            _languageService = languageService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> InformationCheck(InformationStatus status)
        {
            var info = await _informationService.GetInformationListAsync(status);
            if(InformationStatus.About == status)
            {
                if(info == null)
                {
                    return RedirectToAction("CreateAbout");
                }
                else
                {
                    return RedirectToAction("EditAbout", new { status = status });
                }
            }
            else if (InformationStatus.Advertising == status)
            {
                if (info == null)
                {
                    return RedirectToAction("CreateAdvertising");
                }
                else
                {
                    return RedirectToAction("EditAdvertising", new { status = status });
                }
            }
            else if (InformationStatus.FooterInfo == status)
            {
                if (info == null)
                {
                    return RedirectToAction("CreateFooterInfo");
                }
                else
                {
                    return RedirectToAction("EditFooterInfo", new { status = status });
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult CreateAbout()
        {
            ViewBag.Languages = _languageService.GetAllPublishLanguage();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAbout(CreateInformationDTO value)
        {
            if (ModelState.IsValid)
            {
                await _informationService.CreateInformationAsync(value);
                return RedirectToAction("InformationCheck", new { status = value.InformationStatus });
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage();
            return View(value);
        }

        [HttpGet]
        public async Task<IActionResult> EditAbout(InformationStatus status)
        {
            var info = await _informationService.GetEditInformationAsync(status);

            ViewBag.Languages = _languageService.GetAllPublishLanguage();

            return View(info);
        }

        [HttpPost]
        public async Task<IActionResult> EditAbout(EditInformationDTO value)
        {
            if (ModelState.IsValid)
            {
                await _informationService.EditInformationAsync(value);
                return RedirectToAction("InformationCheck", new { status = value.InformationStatus });
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage();
            return View(value);
        }





        [HttpGet]
        public IActionResult CreateAdvertising()
        {
            ViewBag.Languages = _languageService.GetAllPublishLanguage();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAdvertising(CreateInformationDTO value)
        {
            if (ModelState.IsValid)
            {
                await _informationService.CreateInformationAsync(value);
                return RedirectToAction("InformationCheck", new { status = value.InformationStatus });
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage();
            return View(value);
        }

        [HttpGet]
        public async Task<IActionResult> EditAdvertising(InformationStatus status)
        {
            var info = await _informationService.GetEditInformationAsync(status);

            ViewBag.Languages = _languageService.GetAllPublishLanguage();

            return View(info);
        }

        [HttpPost]
        public async Task<IActionResult> EditAdvertising(EditInformationDTO value)
        {
            if (ModelState.IsValid)
            {
                await _informationService.EditInformationAsync(value);
                return RedirectToAction("InformationCheck", new { status = value.InformationStatus });
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage();
            return View(value);
        }





        [HttpGet]
        public IActionResult CreateFooterInfo()
        {
            ViewBag.Languages = _languageService.GetAllPublishLanguage();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateFooterInfo(CreateInformationDTO value)
        {
            if (ModelState.IsValid)
            {
                await _informationService.CreateInformationAsync(value);
                return RedirectToAction("InformationCheck", new { status = value.InformationStatus });
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage();
            return View(value);
        }

        [HttpGet]
        public async Task<IActionResult> EditFooterInfo(InformationStatus status)
        {
            var info = await _informationService.GetEditInformationAsync(status);

            ViewBag.Languages = _languageService.GetAllPublishLanguage();

            return View(info);
        }

        [HttpPost]
        public async Task<IActionResult> EditFooterInfo(EditInformationDTO value)
        {
            if (ModelState.IsValid)
            {
                await _informationService.EditInformationAsync(value);
                return RedirectToAction("InformationCheck", new { status = value.InformationStatus });
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage();
            return View(value);
        }
    }
}
