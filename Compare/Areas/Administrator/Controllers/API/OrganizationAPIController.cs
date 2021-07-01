using Compare.Binder;
using Compare.BLL.DTOs.Organization;
using Compare.BLL.Services.Organization;
using Compare.DAL.Models.User;
using DevExtreme.AspNet.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compare.Areas.Administrator.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationAPIController : ControllerBase
    {
        private readonly IOrganizationService _organizationService;
        private readonly UserManager<ApplicationUser> _userManager;

        public OrganizationAPIController(IOrganizationService organizationService, UserManager<ApplicationUser> userManager)
        {
            _organizationService = organizationService;
            _userManager = userManager;
        }

        // GET: api/OrganizationAPI
        [HttpGet]
        [Authorize(Roles = "Admin, Directory management, User")]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load<OrganizationDTO>(_organizationService.GetAllOrganizations().AsQueryable(), loadOptions);
        }

        // DELETE: api/OrganizationAPI/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin, Directory management")]
        public async Task Delete(int id)
        {
            await _organizationService.RemoveOrganizationAsync(id);
        }



        // GET: api/OrganizationAPI/GetOrganizationApi
        [HttpGet("GetOrganizationApi")]
        [Authorize(Roles = "Admin, Directory management")]
        public object GetOrganizationApi(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load<OrganizationApiDTO>(_organizationService.GetAllApiOrganizations().AsQueryable(), loadOptions);
        }

        // DELETE: api/OrganizationAPI/DeleteOrganizationApi/5
        [HttpDelete("DeleteOrganizationApi/{id}")]
        [Authorize(Roles = "Admin, Directory management")]
        public async Task DeleteOrganizationApi(int id)
        {
            await _organizationService.RemoveOrganizationApiAsync(id);
        }



        // GET: api/OrganizationAPI/GetOrganizationProductsApi
        [HttpGet("GetOrganizationProductsApi")]
        [Authorize(Roles = "Admin, Directory management")]
        public object GetOrganizationProductsApi(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load<OrganizationProductListDTO>(_organizationService.GetAllOrganizationProducts().AsQueryable(), loadOptions);
        }

        // GET: api/OrganizationAPI/GetStoreProductsApi
        [HttpGet("GetStoreProductsApi")]
        [Authorize(Roles = "Admin, Organization")]
        public async Task<object> GetStoreProductsApi(DataSourceLoadOptions loadOptions)
        {
            var user = await _userManager.GetUserAsync(User);
            return DataSourceLoader.Load<OrganizationProductListDTO>(_organizationService.GetOrganizationProducts((int)user.OrganizationId).AsQueryable(), loadOptions);
        }

        // DELETE: api/OrganizationAPI/DeleteOrganizationProductApi/5
        [HttpDelete("DeleteOrganizationProductApi/{id}")]
        [Authorize(Roles = "Admin, Organization, Directory management")]
        public async Task DeleteOrganizationProductApi(int id)
        {
            var user = await _userManager.GetUserAsync(User);
            await _organizationService.RemoveOrganizationProductAsync(id, user);
        }
    }
}
