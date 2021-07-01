using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Compare.BLL.DTOs.Commentary.ProductCommentary;
using Compare.BLL.Services.ProductCommentary;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Compare.Areas.Identity.Pages.Account.Manage.ProductComments
{
    [Authorize]
    public class EditModel : PageModel
    {
        private readonly IProductCommentService _productCommentService;

        public EditModel(IProductCommentService productCommentService)
        {
            _productCommentService = productCommentService;
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

            public int ProductId { get; set; }
        }

        private void Load(ProductCommentEditDto model)
        {
            Input = new InputModel()
            {
                Id = model.Id,
                Name = model.Name,
                ProductId = model.ProductId,
                Description = model.Description,
                PublicateDate = model.PublicateDate,
                IsPublish = model.IsPublish,
                ApplicationUserId = model.ApplicationUserId
            };
        }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            var editOrganizationProductDTO = await _productCommentService.GetProductCommentAsync(id);

            Load(editOrganizationProductDTO);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            ProductCommentEditDto productCommentEditDto = new ProductCommentEditDto()
            {
                Id = Input.Id,
                Name = Input.Name,
                ProductId = Input.ProductId,
                Description = Input.Description,
                PublicateDate = Input.PublicateDate,
                IsPublish = Input.IsPublish,
                ApplicationUserId = Input.ApplicationUserId
            };

            try
            {
                await _productCommentService.EditProductCommentAsync(productCommentEditDto);
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
