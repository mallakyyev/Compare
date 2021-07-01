using Compare.Binder;
using Compare.BLL.DTOs.Product;
using Compare.BLL.Services.Product;
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
    public class ProductAPIController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly UserManager<ApplicationUser> _userManager;

        public ProductAPIController(IProductService productService, UserManager<ApplicationUser> userManager)
        {
            _productService = productService;
            _userManager = userManager;
        }

        // GET: api/ProductAPI
        [HttpGet]
        [Authorize(Roles = "Admin, Directory management, User")]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load<ProductDTO>(_productService.GetAllProducts().AsQueryable(), loadOptions);
        }

        // GET: api/ProductAPI/GetProductCategoryParentList/parentId=5
        [HttpGet("GetProductCategoryParentList")]
        [Authorize(Roles = "Admin, Directory management")]
        public object GetProductCategoryParentList(DataSourceLoadOptions loadOptions, int parentId)
        {
            return DataSourceLoader.Load<ProductDTO>(_productService.GetProductCategoryList(parentId).AsQueryable(), loadOptions);
        }

        // GET: api/ProductAPI/GetAllProductsOrganizationSubscription
        [HttpGet("GetAllProductsOrganizationSubscription")]
        [Authorize(Roles = "Admin, Organization")]
        public async Task<object> GetAllProductsOrganizationSubscription(DataSourceLoadOptions loadOptions)
        {
            var user = await _userManager.GetUserAsync(User);
            return DataSourceLoader.Load<ProductDTO>(_productService.GetAllProductsOrganizationSubscription((int)user.OrganizationId).AsQueryable(), loadOptions);
        }

        // GET: api/ProductAPI/5
        [HttpGet("{id}")]
        [Authorize(Roles = "Admin, Directory management")]
        public async Task<IActionResult> Get(int id)
        {
            EditProductDTO editProductDTO = await _productService.GetProductAsync(id);
            return Ok(editProductDTO);
        }

        // POST: api/ProductAPI
        [HttpPost]
        [Authorize(Roles = "Admin, Directory management")]
        public async Task<IActionResult> Post([FromForm] CreateProductDTO value)
        {
            if (ModelState.IsValid)
            {
                await _productService.CreateProductAsync(value);
                return Ok(value);
            }
            return BadRequest();
        }

        // PUT: api/ProductAPI/5
        [HttpPut]
        [Authorize(Roles = "Admin, Directory management")]
        public async Task<IActionResult> Put([FromForm] EditProductDTO value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _productService.EditProductAsync(value);

            return Ok(value);
        }

        // DELETE: api/ProductAPI/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin, Directory management")]
        public async Task Delete(int id)
        {
            await _productService.RemoveProductAsync(id);
        }

        [HttpGet("GetProductMediasId/{id}")]
        [Authorize(Roles = "Admin, Directory management")]
        public IActionResult GetProductMediasId(int id)
        {
            var productMediaDTOs = _productService.GetProductMedias(id);
            return Ok(productMediaDTOs);
        }

        [HttpDelete("RemoveMediaId/{id}")]
        [Authorize(Roles = "Admin, Directory management")]
        public async Task RemoveMediaId(int id)
        {
            await _productService.RemoveProductMediaAsync(id);
        }
    }
}
