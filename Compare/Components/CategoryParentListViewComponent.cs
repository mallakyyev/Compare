using Compare.BLL.Services.Catalog;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compare.Components
{
    public class CategoryParentListViewComponent: ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public CategoryParentListViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryService.GetAllPublishCategory().Where(p => p.ParentCategoryId == null)
                .OrderBy(o => o.DisplayOrder);
            return View(categories);
        }
    }
}
