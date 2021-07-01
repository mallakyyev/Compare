using Compare.Binder;
using Compare.BLL.DTOs.ProductOption;
using Compare.BLL.Services.ProductOption;
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
    public class ProductOptionAPIController : ControllerBase
    {
        private readonly IProductOptionService _productOptionService;

        public ProductOptionAPIController(IProductOptionService productOptionService)
        {
            _productOptionService = productOptionService;
        }

        // GET: api/ProductOptionAPI
        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load<ProductOptionListDTO>(_productOptionService.GetAllproductOption().AsQueryable(), loadOptions);
        }

        // DELETE: api/BannerAPI/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _productOptionService.RemoveProductOptionAsync(id);
        }
    }
}
