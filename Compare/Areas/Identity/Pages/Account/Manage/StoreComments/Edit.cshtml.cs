using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Compare.BLL.DTOs.Commentary.StoreCommentary;
using Compare.BLL.Services.StoreCommentary;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Compare.Areas.Identity.Pages.Account.Manage.StoreComments
{
    [Authorize]
    public class EditModel : PageModel
    {
        private readonly IStoreCommentService _storeCommentService;

        public EditModel(IStoreCommentService storeCommentService)
        {
            _storeCommentService = storeCommentService;
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
            public string Name { get; set; }

            [Required]
            public string Description { get; set; }

            public DateTime PublicateDate { get; set; }

            public bool IsPublish { get; set; }

            public string ApplicationUserId { get; set; }

            public int OrganizationId { get; set; }
        }

        private void Load(StoreCommentEditDto model)
        {
            Input = new InputModel()
            {
                Id = model.Id,
                Name = model.Name,
                OrganizationId = model.OrganizationId,
                Description = model.Description,
                PublicateDate = model.PublicateDate,
                IsPublish = model.IsPublish,
                ApplicationUserId = model.ApplicationUserId
            };
        }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            var storeCommentEditDto = await _storeCommentService.GetStoreCommentAsync(id);

            Load(storeCommentEditDto);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            StoreCommentEditDto storeCommentEditDto = new StoreCommentEditDto()
            {
                Id = Input.Id,
                Name = Input.Name,
                OrganizationId = Input.OrganizationId,
                Description = Input.Description,
                PublicateDate = Input.PublicateDate,
                IsPublish = Input.IsPublish,
                ApplicationUserId = Input.ApplicationUserId
            };

            try
            {
                await _storeCommentService.EditStoreCommentAsync(storeCommentEditDto);
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
