using Compare.BLL.DTOs.Commentary.ProductCommentary;
using Compare.BLL.Services.ProductCommentary;
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
    public class ProductCommentController : Controller
    {
        private readonly IProductCommentService _productCommentService;
        private readonly UserManager<ApplicationUser> _userManager;

        public ProductCommentController(IProductCommentService productCommentService, UserManager<ApplicationUser> userManager)
        {
            _productCommentService = productCommentService;
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
        public async Task<IActionResult> Create(ProductCommentCreateDto value)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);
                value.ApplicationUserId = user.Id;
                await _productCommentService.CreateProductCommentAsync(value);
                return RedirectToAction("Index");
            }
            return View(value);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var commentEditDto = await _productCommentService.GetProductCommentAsync(id);

            return View(commentEditDto);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ProductCommentEditDto value)
        {
            if (ModelState.IsValid)
            {
                await _productCommentService.EditProductCommentAsync(value);
                return RedirectToAction("Index");
            }
            return View(value);
        }
    }
}
