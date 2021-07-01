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
    public class EditModel : PageModel
    {
        private readonly IOrganizationService _organizationService;
        private readonly UserManager<ApplicationUser> _userManager;

        public EditModel(IOrganizationService organizationService, UserManager<ApplicationUser> userManager)
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
            public int Id { get; set; }

            [Required]
            public int ProductId { get; set; }

            [Required]
            public double Price { get; set; }

            [Required]
            public bool InStock { get; set; }

            [Required]
            public bool OfficialDealer { get; set; }

            [Required]
            public int OrganizationId { get; set; }
        }

        private void Load(EditOrganizationProductDTO model)
        {
            Input = new InputModel()
            {
                Id = model.Id,
                OrganizationId = model.OrganizationId,
                ProductId = model.ProductId,
                Price = model.Price,
                InStock = model.InStock,
                OfficialDealer = model.OfficialDealer
            };
        }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            var editOrganizationProductDTO = await _organizationService.GetOrganizationProductAsync(id);

            Load(editOrganizationProductDTO);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            EditOrganizationProductDTO editOrganizationProductDTO = new EditOrganizationProductDTO()
            {
                Id = Input.Id,
                OrganizationId = Input.OrganizationId,
                ProductId = Input.ProductId,
                Price = Input.Price,
                InStock = Input.InStock,
                OfficialDealer = Input.OfficialDealer
            };

            try
            {
                await _organizationService.EditOrganizationProductAsync(editOrganizationProductDTO);
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
