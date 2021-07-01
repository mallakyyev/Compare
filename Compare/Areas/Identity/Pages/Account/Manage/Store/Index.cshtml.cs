using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Compare.BLL.DTOs.Organization;
using Compare.BLL.Services.Organization;
using Compare.DAL.Models.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Localization;

namespace Compare.Areas.Identity.Pages.Account.Manage.Store
{
    [Authorize(Roles = "Organization")]
    public class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IOrganizationService _organizationService;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResource> _sharedLocalizer;

        public IndexModel(UserManager<ApplicationUser> userManager, IOrganizationService organizationService,
            IMapper mapper, IStringLocalizer<SharedResource> sharedLocalizer)
        {
            _userManager = userManager;
            _organizationService = organizationService;
            _mapper = mapper;
            _sharedLocalizer = sharedLocalizer;
        }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public EditOrganizationDTO Input { get; set; }

        private async Task LoadAsync(ApplicationUser user)
        {
            var organization = await _organizationService.GetOrganizationAsync((int)user.OrganizationId);
            Input = _mapper.Map<EditOrganizationDTO>(organization);
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            Input.ApplicationUserId = user.Id;
            await _organizationService.EditOrganizationAsync(Input);
            
            StatusMessage = _sharedLocalizer["Your store has been updated"];
            return RedirectToPage();
        }
    }
}
