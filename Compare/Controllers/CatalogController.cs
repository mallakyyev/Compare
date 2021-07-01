using Compare.BLL.Services.Catalog;
using Compare.BLL.Services.CatalogPanel;
using Compare.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compare.Controllers
{
    public class CatalogController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly ICategoryPanelService _categoryPanelService;

        public CatalogController(ICategoryService categoryService, ICategoryPanelService categoryPanelService)
        {
            _categoryService = categoryService;
            _categoryPanelService = categoryPanelService;
        }

        public IActionResult Index(int parentId)
        {
            var categories = _categoryService.GetAllPublishCategoryByParentId(parentId).OrderBy(o => o.DisplayOrder);
            var categoryPanels = _categoryPanelService.GetAllPublishCategoryPanelsByCategoryId(parentId);

            CategoryPageViewModel categoryPageViewModel = new CategoryPageViewModel
            {
                CategoryList = categories,
                CategoryPanelList = categoryPanels
            };

            return View(categoryPageViewModel);
        }
    }
}
