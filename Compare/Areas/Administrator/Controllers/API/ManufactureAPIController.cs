using Compare.Binder;
using Compare.BLL.DTOs.Manufacture;
using Compare.BLL.Services.Manufacture;
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
    public class ManufactureAPIController : ControllerBase
    {
        private readonly IManufactureService _manufactureService;

        public ManufactureAPIController(IManufactureService manufactureService)
        {
            _manufactureService = manufactureService;
        }

        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load<ManufactureDTO>(_manufactureService.GetAllManufacture().AsQueryable(), loadOptions);
        }

        // GET: api/Manufacture/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Manufacture
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateManufactureDTO value)
        {
            if (ModelState.IsValid)
            {
                await _manufactureService.CreateManufacture(value);
                return Ok(value);
            }
            return BadRequest();
        }

        // PUT: api/Manufacture/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] ManufactureDTO value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != value.Id)
            {
                return BadRequest();
            }

            await _manufactureService.EditManufacture(value);

            return Ok(value);
        }

        // DELETE: api/Manufacture/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _manufactureService.RemoveManufacture(id);
        }
    }
}
