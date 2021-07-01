using Compare.Binder;
using Compare.BLL.DTOs.Organization;
using Compare.BLL.Services.Organization;
using DevExtreme.AspNet.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compare.PublicApi
{
    [Route("public/[controller]")]
    [ApiController]
    public class OrganizationProductApiController : ControllerBase
    {
        private readonly IOrganizationService _organizationService;

        public OrganizationProductApiController(IOrganizationService organizationService)
        {
            _organizationService = organizationService;
        }

        // POST: public/OrganizationProductApi
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] OrganizationProductDTO value)
        {
            if (ModelState.IsValid)
            {
                await _organizationService.EditOrganizationProductPriceAsync(value.OrganizationId, (int)value.OrganizationProductId, value.Price, value.InStock);
                return Ok(value);
            }
            return BadRequest();
        }
    }
}
