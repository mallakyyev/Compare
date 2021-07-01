using Compare.Binder;
using Compare.BLL.DTOs.Catalog;
using Compare.BLL.Services.Catalog;
using DevExtreme.AspNet.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compare.Areas.Administrator.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin, Directory management")]
    public class CategoryAPIController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryAPIController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        // GET: api/CategoryAPI
        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load<CategoryDTO>(_categoryService.GetAllCategory().AsQueryable(), loadOptions);
        }

        // GET: api/CategoryAPI/GetAllPublishCategoryParent
        [HttpGet("GetAllPublishCategoryParent")]
        public object GetAllPublishCategoryParent(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load<CategoryDTO>(_categoryService.GetAllPublishCategoryParent().AsQueryable(), loadOptions);
        }

        // Post: api/CategoryAPI/GetAllPublishCategory
        [HttpGet("GetAllPublishCategory")]
        public IActionResult GetAllPublishCategory()
        {
            var categories = _categoryService.GetAllPublishCategory().AsQueryable();
            return Ok(categories);
        }

        // DELETE: api/CategoryAPI/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _categoryService.RemoveCategoryAsync(id);
        }
    }
}
