using Compare.Binder;
using Compare.BLL.DTOs.Advertising;
using Compare.BLL.Services.Advertising;
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
    public class AdvertAPIController : ControllerBase
    {
        private readonly IAdvertService _advertService;

        public AdvertAPIController(IAdvertService advertService)
        {
            _advertService = advertService;
        }

        // GET: api/AdvertAPI
        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load<AdvertListDTO>(_advertService.GetAllAdverts().AsQueryable(), loadOptions);
        }

        // DELETE: api/AdvertAPI/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _advertService.RemoveAdvertAsync(id);
        }
    }
}
