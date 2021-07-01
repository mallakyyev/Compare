using Compare.BLL.DTOs.User;
using Compare.BLL.Services.User;
using Compare.DAL.Models.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compare.Areas.Administrator.Controllers.User
{
    [Area("Administrator")]
    [Authorize(Roles = "Admin")]
    public class ApplicationUserController : Controller
    {
        private readonly IApplicationUserService _applicationUserService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public ApplicationUserController(IApplicationUserService applicationUserService, UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _applicationUserService = applicationUserService;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            ViewBag.RolesList = new SelectList(roles.OrderBy(o => o.Name), "Name", "Name");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateApplicationUserDTO model)
        {
            var roles = await _roleManager.Roles.ToListAsync();
            ViewBag.RolesList = new SelectList(roles.OrderBy(o => o.Name), "Name", "Name", model.Role);
            if (ModelState.IsValid)
            {
                await _applicationUserService.CreateApplicationUserAsync(model);
                return RedirectToAction("Index");
            }
            
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var user = await _applicationUserService.GetEditApplicationUserAsync(id);
            var roles = await _roleManager.Roles.ToListAsync();
            var selectedRoleNames = await _applicationUserService.GetRolesAsync(id);
            ViewBag.RolesList = new SelectList(roles.OrderBy(o => o.Name), "Name", "Name", selectedRoleNames.FirstOrDefault());
            user.Role = selectedRoleNames.FirstOrDefault();

            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditApplicationUserDTO model)
        {
            var roles = await _roleManager.Roles.ToListAsync();
            ViewBag.RolesList = new SelectList(roles.OrderBy(o => o.Name), "Name", "Name", model.Role);

            if (ModelState.IsValid)
            {
                await _applicationUserService.EditApplicationUserAsync(model);
                return RedirectToAction("Index");
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> ChangePassword(string id)
        {
            var user = await _applicationUserService.UserFindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            else
            {
                ChangePasswordDTO userForChangePass = new ChangePasswordDTO
                {
                    Email = await _userManager.GetEmailAsync(user),
                    UserName = user.UserName,
                    Id = id
                };
                return View(userForChangePass);
            }
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordDTO model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var result = await _applicationUserService.ChangePasswordAsync(model);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.ErrorList = result.Errors.ToList();
                return View(model);
            }

        }
    }
}
