using Compare.BLL.DTOs.Organization;
using Compare.BLL.Services.OrganizationSubscription;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compare.Areas.Administrator.Controllers.OrganizationSubscription
{
    [Area("Administrator")]
    [Authorize(Roles = "Admin")]
    public class OrganizationSubscriptionController : Controller
    {
        private readonly IOrganizationSubscriptionService _organizationSubscriptionService;

        public OrganizationSubscriptionController(IOrganizationSubscriptionService organizationSubscriptionService)
        {
            _organizationSubscriptionService = organizationSubscriptionService;
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
        public async Task<IActionResult> Create(CreateOrganizationSubscriptionDTO value)
        {
            if (ModelState.IsValid)
            {
                await _organizationSubscriptionService.CreateOrganizationSubscriptionAsync(value);
                return RedirectToAction("Index");
            }
            return View(value);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var editOrganizationSubscriptionDTO = await _organizationSubscriptionService.GetOrganizationSubscriptionAsync(id);

            return View(editOrganizationSubscriptionDTO);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditOrganizationSubscriptionDTO value)
        {
            if (ModelState.IsValid)
            {
                await _organizationSubscriptionService.EditOrganizationSubscriptionAsync(value);
                return RedirectToAction("Index");
            }

            return View(value);
        }
    }
}
