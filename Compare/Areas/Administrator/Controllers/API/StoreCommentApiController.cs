using Compare.Binder;
using Compare.BLL.DTOs.Commentary.StoreCommentary;
using Compare.BLL.Services.StoreCommentary;
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
    public class StoreCommentApiController : ControllerBase
    {
        private readonly IStoreCommentService _storeCommentService;
        private readonly UserManager<ApplicationUser> _userManager;

        public StoreCommentApiController(IStoreCommentService storeCommentService, UserManager<ApplicationUser> userManager)
        {
            _storeCommentService = storeCommentService;
            _userManager = userManager;
        }

        // GET: api/StoreCommentApi
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load<StoreCommentListDto>(_storeCommentService.GetAllStoreComments().AsQueryable(), loadOptions);
        }

        // GET: api/StoreCommentApi/GetAllStoreCommentsByUser
        [HttpGet("GetAllStoreCommentsByUser")]
        [Authorize(Roles = "Admin, User")]
        public async Task<object> GetAllStoreCommentsByUser(DataSourceLoadOptions loadOptions)
        {
            var user = await _userManager.GetUserAsync(User);

            return DataSourceLoader.Load<StoreCommentListDto>(_storeCommentService.GetAllStoreCommentsByUser(user.Id).AsQueryable(), loadOptions);
        }

        // DELETE: api/StoreCommentApi/5
        [HttpDelete("{id}")]
        [Authorize]
        public async Task Delete(int id)
        {
            await _storeCommentService.RemoveStoreCommentAsync(id);
        }
    }
}
