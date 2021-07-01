using Compare.BLL.DTOs.Organization;
using Compare.BLL.Services.Organization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compare.Areas.Administrator.Controllers.Organization
{
    [Area("Administrator")]
    [Authorize(Roles = "Admin, Directory management")]
    public class OrganizationController : Controller
    {
        private readonly IOrganizationService _organizationService;

        public OrganizationController(IOrganizationService organizationService)
        {
            _organizationService = organizationService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateOrganizationDTO value)
        {
            if (ModelState.IsValid)
            {
                await _organizationService.CreateOrganizationAsync(value);
                return RedirectToAction("Index");
            }
            return View(value);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var organization = await _organizationService.GetOrganizationAsync(id);

            return View(organization);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditOrganizationDTO value)
        {
            if (ModelState.IsValid)
            {
                await _organizationService.EditOrganizationAsync(value);
                return RedirectToAction("Index");
            }

            return View(value);
        }

        public IActionResult IndexOrganizationApi()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateOrganizationApi()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrganizationApi(CreateOrganizationApiDTO value)
        {
            if (ModelState.IsValid)
            {
                await _organizationService.CreateOrganizationApiAsync(value);
                return RedirectToAction("IndexOrganizationApi");
            }
            return View(value);
        }

        [HttpGet]
        public async Task<IActionResult> EditOrganizationApi(int id)
        {
            var organizationApiDTO = await _organizationService.GetOrganizationApiAsync(id);

            return View(organizationApiDTO);
        }

        [HttpPost]
        public async Task<IActionResult> EditOrganizationApi(EditOrganizationApiDTO value)
        {
            if (ModelState.IsValid)
            {
                await _organizationService.EditOrganizationApiAsync(value);
                return RedirectToAction("IndexOrganizationApi");
            }

            return View(value);
        }


        [Authorize(Roles = "Admin, Directory management")]
        public IActionResult IndexOrganizationProduct()
        {
            return View();
        }

        [HttpGet]
        [Authorize(Roles = "Admin, Directory management")]
        public IActionResult CreateOrganizationProduct()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin, Directory management")]
        public async Task<IActionResult> CreateOrganizationProduct(CreateOrganizationProductDTO value)
        {
            if (ModelState.IsValid)
            {
                await _organizationService.CreateOrganizationProductAsync(value);
                return RedirectToAction("IndexOrganizationProduct");
            }
            return View(value);
        }

        [HttpGet]
        [Authorize(Roles = "Admin, Directory management")]
        public async Task<IActionResult> EditOrganizationProduct(int id)
        {
            var organization = await _organizationService.GetOrganizationProductAsync(id);

            return View(organization);
        }

        [HttpPost]
        [Authorize(Roles = "Admin, Directory management")]
        public async Task<IActionResult> EditOrganizationProduct(EditOrganizationProductDTO value)
        {
            if (ModelState.IsValid)
            {
                await _organizationService.EditOrganizationProductAsync(value);
                return RedirectToAction("IndexOrganizationProduct");
            }

            return View(value);
        }
    }
}
