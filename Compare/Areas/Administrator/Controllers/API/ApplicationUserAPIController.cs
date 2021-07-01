using Compare.Binder;
using Compare.BLL.DTOs.User;
using Compare.BLL.Services.User;
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
    public class ApplicationUserAPIController : ControllerBase
    {
        private readonly IApplicationUserService _applicationUserService;

        public ApplicationUserAPIController(IApplicationUserService applicationUserService)
        {
            _applicationUserService = applicationUserService;
        }

        // GET: api/ApplicationUserAPI
        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load<ApplicationUserListDTO>(_applicationUserService.GetAllUsers().AsQueryable(), loadOptions);
        }

        // DELETE: api/ApplicationUserAPI/5
        [HttpDelete("{id}")]
        public async Task Delete(string id)
        {
            await _applicationUserService.RemoveApplicationUserAsync(id);
        }
    }
}
