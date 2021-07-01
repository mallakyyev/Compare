using Compare.BLL.DTOs.Commentary.StoreCommentary;
using Compare.BLL.Services.Organization;
using Compare.BLL.Services.StoreCommentary;
using Compare.DAL.Models.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compare.Controllers
{
    public class StoreController : Controller
    {
        private readonly IOrganizationService _organizationService;
        private readonly IStoreCommentService _storeCommentService;
        private readonly UserManager<ApplicationUser> _userManager;

        public StoreController(IOrganizationService organizationService,
            IStoreCommentService storeCommentService, UserManager<ApplicationUser> userManager)
        {
            _organizationService = organizationService;
            _storeCommentService = storeCommentService;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Detail(int storeId, string alert_message)
        {
            ViewBag.AlertMessage = alert_message;
            var organization = await _organizationService.GetOrganizationDetailAsync(storeId);
            return View(organization);
        }

        [HttpPost]
        public async Task<IActionResult> SendComment(StoreCommentCreateDto model)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    var user = await _userManager.GetUserAsync(User);
                    model.ApplicationUserId = user.Id;
                    await _storeCommentService.CreateStoreCommentAsync(model);

                    return RedirectToAction("Detail", new { storeId = model.OrganizationId, alert_message = "success" });
                }
                return RedirectToAction("Detail", new { storeId = model.OrganizationId, alert_message = "danger" });
            }
            catch (Exception ex)
            {
                return RedirectToAction("Detail", new { storeId = model.OrganizationId, alert_message = "danger" });
            }
        }
    }
}
