using Compare.Binder;
using Compare.BLL.DTOs.CatalogPanel;
using Compare.BLL.Services.CatalogPanel;
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
    [Authorize(Roles = "Admin")]
    public class CategoryPanelAPIController : ControllerBase
    {
        private readonly ICategoryPanelService _categoryPanelService;

        public CategoryPanelAPIController(ICategoryPanelService categoryPanelService)
        {
            _categoryPanelService = categoryPanelService;
        }

        // GET: api/CategoryPanelAPI
        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load<CategoryPanelListDTO>(_categoryPanelService.GetAllCategoryPanels().AsQueryable(), loadOptions);
        }

        // DELETE: api/CategoryPanelAPI/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _categoryPanelService.RemoveCategoryPanelAsync(id);
        }
    }
}
