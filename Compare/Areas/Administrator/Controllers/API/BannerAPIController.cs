using Compare.Binder;
using Compare.BLL.DTOs.Banner;
using Compare.BLL.Services.Banner;
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
    public class BannerAPIController : ControllerBase
    {
        private readonly IBannerService _bannerService;

        public BannerAPIController(IBannerService bannerService)
        {
            _bannerService = bannerService;
        }

        // GET: api/BannerAPI
        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load<BannerListDTO>(_bannerService.GetAllBanners().AsQueryable(), loadOptions);
        }

        // DELETE: api/BannerAPI/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _bannerService.RemoveBannerAsync(id);
        }
    }
}
