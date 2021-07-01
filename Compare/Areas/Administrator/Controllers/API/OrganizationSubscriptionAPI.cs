using Compare.Binder;
using Compare.BLL.DTOs.Organization;
using Compare.BLL.Services.OrganizationSubscription;
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
    public class OrganizationSubscriptionAPI : ControllerBase
    {
        private readonly IOrganizationSubscriptionService _organizationSubscriptionService;
        private readonly UserManager<ApplicationUser> _userManager;

        public OrganizationSubscriptionAPI(IOrganizationSubscriptionService organizationSubscriptionService,
            UserManager<ApplicationUser> userManager)
        {
            _organizationSubscriptionService = organizationSubscriptionService;
            _userManager = userManager;
        }

        // GET: api/OrganizationSubscriptionAPI
        [HttpGet]
        [Authorize(Roles = "Admin, Directory management")]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load<OrganizationSubscriptionListDTO>(_organizationSubscriptionService.GetAllOrganizationSubscriptions().AsQueryable(), loadOptions);
        }

        // GET: api/OrganizationSubscriptionAPI/OrganizationSubscriptionsById
        [HttpGet("OrganizationSubscriptionsById")]
        [Authorize(Roles = "Admin, Organization")]
        public async Task<object> OrganizationSubscriptionsById(DataSourceLoadOptions loadOptions)
        {
            var user = await _userManager.GetUserAsync(User);
            return DataSourceLoader.Load<OrganizationSubscriptionListDTO>(_organizationSubscriptionService.GetOrganizationSubscriptionsById((int)user.OrganizationId).AsQueryable(), loadOptions);
        }

        // DELETE: api/OrganizationSubscriptionAPI/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin, Directory management")]
        public async Task Delete(int id)
        {
            await _organizationSubscriptionService.RemoveOrganizationSubscriptionAsync(id);
        }
    }
}
