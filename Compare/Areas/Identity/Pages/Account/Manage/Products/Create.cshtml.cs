using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Compare.BLL.DTOs.Organization;
using Compare.BLL.Services.Organization;
using Compare.DAL.Models.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Compare.Areas.Identity.Pages.Account.Manage.Products
{
    [Authorize(Roles = "Organization")]
    public class CreateModel : PageModel
    {
        private readonly IOrganizationService _organizationService;
        private readonly UserManager<ApplicationUser> _userManager;

        public CreateModel(IOrganizationService organizationService, UserManager<ApplicationUser> userManager)
        {
            _organizationService = organizationService;
            _userManager = userManager;
        }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required]
            public int ProductId { get; set; }

            [Required]
            public double Price { get; set; }

            [Required]
            public bool InStock { get; set; }

            [Required]
            public bool OfficialDealer { get; set; }
        }

        //private async Task LoadAsync(ApplicationUser user)
        //{
        //    OrganizationId = (int)user.OrganizationId;
        //}

        public async Task<IActionResult> OnGetAsync()
        {
            //var user = await _userManager.GetUserAsync(User);
            //if (user == null)
            //{
            //    return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            //}

            //await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            CreateOrganizationProductDTO createOrganizationProductDTO = new CreateOrganizationProductDTO()
            {
                OrganizationId = (int)user.OrganizationId,
                ProductId = Input.ProductId,
                Price = Input.Price,
                InStock = Input.InStock,
                OfficialDealer = Input.OfficialDealer
            };
            
            try
            {
                await _organizationService.CreateOrganizationProductAsync(createOrganizationProductDTO);
            }
            catch (Exception ex)
            {
                StatusMessage = ex.Message;
                return RedirectToPage();
            }


            return RedirectToPage("Index");
        }
    }
}
