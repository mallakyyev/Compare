using Compare.BLL.DTOs.Cart.Basket;
using Compare.BLL.Services.Cart.Basket;
using Compare.DAL.Models.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Compare.Areas.Administrator.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketAPIController : ControllerBase
    {
        private readonly IBasketService _basketService;
        private readonly UserManager<ApplicationUser> _userManager;

        public BasketAPIController(IBasketService basketService, UserManager<ApplicationUser> userManager)
        {
            _basketService = basketService;
            _userManager = userManager;
        }

        // GET: api/BasketAPI/GetAllBasketProductsByApplicationUserId
        [HttpGet("GetAllBasketProductsByApplicationUserId")]
        public async Task<IEnumerable<BasketListDto>> GetAllBasketProductsByApplicationUserId()
        {
            var user = await _userManager.GetUserAsync(User);
            return await _basketService.GetAllBasketProductsByApplicationUserId(user.Id);
        }

        // GET api/<CartAPIController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/BasketAPI
        [HttpPost]
        public async Task Post([FromBody] BasketCreateDto model)
        {
            var user = await _userManager.GetUserAsync(User);
            model.ApplicationUserId = user.Id;

            await _basketService.CreateProductInToBasketAsync(model);
        }

        // PUT api/BasketAPI/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CartAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
