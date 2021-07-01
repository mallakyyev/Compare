using Compare.Binder;
using Compare.BLL.DTOs.ProductAttributeTemplate;
using Compare.BLL.Services.ProductAttributeTemplate;
using DevExtreme.AspNet.Data;
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
    public class ProductAttributeTemplateAPIController : ControllerBase
    {
        private readonly IProductAttributeTemplateService _productAttributeTemplateService;

        public ProductAttributeTemplateAPIController(IProductAttributeTemplateService productAttributeTemplateService)
        {
            _productAttributeTemplateService = productAttributeTemplateService;
        }

        // GET: api/ProductAttributeTemplateAPI
        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load<ProductAttributeTemplateListDTO>(_productAttributeTemplateService.GetAllProductAttributeTemplates().AsQueryable(), loadOptions);
        }

        // GET: api/ProductAttributeTemplateAPI/GetProductOptionsCultureListId/{id}
        [HttpGet("GetProductOptionsCultureListId/{id}")]
        public IActionResult GetProductOptionsCultureListId(int id)
        {
            return Ok(_productAttributeTemplateService.GetProductOptionsCultureListId(id).AsQueryable());
        }

        // DELETE: api/ProductAttributeTemplateAPI/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _productAttributeTemplateService.RemoveProductAttributeTemplateAsync(id);
        }
    }
}
