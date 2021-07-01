using Compare.Binder;
using Compare.BLL.DTOs.Panel;
using Compare.BLL.Services.Panel;
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
    public class PanelAPIController : ControllerBase
    {
        private readonly IPanelService _panelService;

        public PanelAPIController(IPanelService panelService)
        {
            _panelService = panelService;
        }

        // GET: api/PanelAPI
        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load<PanelListDTO>(_panelService.GetAllPanels().AsQueryable(), loadOptions);
        }

        // DELETE: api/PanelAPI/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _panelService.RemovePanelAsync(id);
        }
    }
}
