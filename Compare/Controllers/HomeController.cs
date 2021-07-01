using Compare.BLL.Services.Advertising;
using Compare.BLL.Services.Banner;
using Compare.BLL.Services.Catalog;
using Compare.BLL.Services.Info;
using Compare.BLL.Services.Panel;
using Compare.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Compare.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICategoryService _categoryService;
        private readonly IBannerService _bannerService;
        private readonly IPanelService _panelService;
        private readonly IInformationService _informationService;
        private readonly IAdvertService _advertService;

        public HomeController(ILogger<HomeController> logger, ICategoryService categoryService, IBannerService bannerService,
            IPanelService panelService, IInformationService informationService, IAdvertService advertService)
        {
            _logger = logger;
            _categoryService = categoryService;
            _bannerService = bannerService;
            _panelService = panelService;
            _informationService = informationService;
            _advertService = advertService;
        }

        public IActionResult Index()
        {
            //var parentCategories = _categoryService.GetAllPublishCategory().Where(p => p.ParentCategoryId == null)
            //    .OrderBy(o => o.DisplayOrder);
            var bannerList = _bannerService.GetAllPublishBanners()
                .OrderBy(o => o.DisplayOrder);
            var pannelList = _panelService.GetAllPublishPanels()
                .OrderBy(o => o.DisplayOrder);
            var adverts = _advertService.GetFilterAdverts(DAL.Models.Enums.PagePlaceStatus.Home, 0);

            HomeViewModel homeViewModel = new HomeViewModel()
            {
                //ParentCategories = parentCategories,
                BannerList = bannerList,
                PannelList = pannelList,
                AdvertList = adverts
            };
            return View(homeViewModel);
        }

        [HttpGet]
        public async Task<IActionResult> About()
        {
            var about = await _informationService.GetInformationListAsync(DAL.Models.Enums.InformationStatus.About);
            return View(about);
        }

        [HttpGet]
        public async Task<IActionResult> Advertising()
        {
            var advert = await _informationService.GetInformationListAsync(DAL.Models.Enums.InformationStatus.Advertising);
            return View(advert);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            return LocalRedirect(returnUrl);
        }
    }
}
