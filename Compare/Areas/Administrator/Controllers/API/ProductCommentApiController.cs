using Compare.Binder;
using Compare.BLL.DTOs.Commentary.ProductCommentary;
using Compare.BLL.Services.ProductCommentary;
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
    public class ProductCommentApiController : ControllerBase
    {
        private readonly IProductCommentService _productCommentService;
        private readonly UserManager<ApplicationUser> _userManager;

        public ProductCommentApiController(IProductCommentService productCommentService, UserManager<ApplicationUser> userManager)
        {
            _productCommentService = productCommentService;
            _userManager = userManager;
        }

        // GET: api/ProductCommentApi
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load<ProductCommentListDto>(_productCommentService.GetAllProductComments().AsQueryable(), loadOptions);
        }

        // GET: api/ProductCommentApi/GetAllProductCommentsByUser
        [HttpGet("GetAllProductCommentsByUser")]
        [Authorize]
        public async Task<object> GetAllProductCommentsByUser(DataSourceLoadOptions loadOptions)
        {
            var user = await _userManager.GetUserAsync(User);

            return DataSourceLoader.Load<ProductCommentListDto>(_productCommentService.GetAllProductCommentsByUser(user.Id).AsQueryable(), loadOptions);
        }

        // DELETE: api/ProductCommentApi/5
        [HttpDelete("{id}")]
        [Authorize]
        public async Task Delete(int id)
        {
            await _productCommentService.RemoveProductCommentAsync(id);
        }
    }
}
