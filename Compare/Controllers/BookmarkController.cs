using Compare.BLL.Services.Bookmarks;
using Compare.DAL.Models.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compare.Controllers
{
    [Authorize]
    public class BookmarkController : Controller
    {
        private readonly IBookmarkService _bookmarkService;
        private readonly UserManager<ApplicationUser> _userManager;

        public BookmarkController(IBookmarkService bookmarkService, UserManager<ApplicationUser> userManager)
        {
            _bookmarkService = bookmarkService;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string alert_message)
        {
            ViewBag.AlertMessage = alert_message;

            var user = await _userManager.GetUserAsync(User);
            var bookmarkListDtos = _bookmarkService.GetAllBookmarksByUserId(user.Id);

            return View(bookmarkListDtos);
        }

        [HttpPost]
        public async Task<IActionResult> RemoveBookmark(int id)
        {
            try
            {
                await _bookmarkService.RemoveBookmarkAsync(id);
                return RedirectToAction("Index", new { alert_message = "success" });
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", new { alert_message = "error" });
            }
        }

        [HttpPost]
        public async Task<IActionResult> RemoveAllBookmark()
        {
            try
            {
                if (User.Identity.IsAuthenticated)
                {
                    var user = await _userManager.GetUserAsync(User);
                    await _bookmarkService.RemoveAllBookmarksByUserId(user.Id);
                    return RedirectToAction("Index", new { alert_message = "success" });
                }
                else
                {
                    return RedirectToAction("Index", new { alert_message = "error" });
                }
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", new { alert_message = "error" });
            }
        }
    }
}
