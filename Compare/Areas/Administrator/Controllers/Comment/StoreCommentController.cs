using Compare.BLL.DTOs.Commentary.StoreCommentary;
using Compare.BLL.Services.StoreCommentary;
using Compare.DAL.Models.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compare.Areas.Administrator.Controllers.Comment
{
    [Area("Administrator")]
    [Authorize(Roles = "Admin")]
    public class StoreCommentController : Controller
    {
        private readonly IStoreCommentService _storeCommentService;
        private readonly UserManager<ApplicationUser> _userManager;

        public StoreCommentController(IStoreCommentService storeCommentService, UserManager<ApplicationUser> userManager)
        {
            _storeCommentService = storeCommentService;
            _userManager = userManager;
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
        public async Task<IActionResult> Create(StoreCommentCreateDto value)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);
                value.ApplicationUserId = user.Id;
                await _storeCommentService.CreateStoreCommentAsync(value);
                return RedirectToAction("Index");
            }
            return View(value);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var commentEditDto = await _storeCommentService.GetStoreCommentAsync(id);

            return View(commentEditDto);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(StoreCommentEditDto value)
        {
            if (ModelState.IsValid)
            {
                await _storeCommentService.EditStoreCommentAsync(value);
                return RedirectToAction("Index");
            }
            return View(value);
        }
    }
}
