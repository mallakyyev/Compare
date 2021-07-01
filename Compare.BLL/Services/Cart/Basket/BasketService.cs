using AutoMapper;
using Compare.BLL.DTOs.Cart.Basket;
using Compare.DAL.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Compare.DAL.Models.Enums;
using BasketCs = Compare.DAL.Models.Cart.Basket;

namespace Compare.BLL.Services.Cart.Basket
{
    public class BasketService : IBasketService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public BasketService(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task CreateProductInToBasketAsync(BasketCreateDto modelDTO)
        {
            var basket = _mapper.Map<BasketCs>(modelDTO);
            basket.BasketStatus = BasketStatus.NotFormalized;

            await _dbContext.Baskets.AddAsync(basket);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<BasketListDto>> GetAllBasketProductsByApplicationUserId(string userId)
        {
            List<BasketListDto> basketListDtos = new List<BasketListDto>();
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;

            var baskets = await Task.FromResult(_dbContext.Baskets
                .Include(i => i.Product).ThenInclude(i => i.ProductTranslates).AsQueryable()
                .Include(i => i.OrganizationProduct).ThenInclude(t => t.Organization).AsQueryable()
                .Include(i => i.ApplicationUser).AsQueryable()
                .Where(p => p.ApplicationUserId == userId));

            foreach(var basket in baskets)
            {
                basketListDtos.Add(new BasketListDto
                {
                    Id = basket.Id,
                    Price = (double)basket.OrganizationProduct?.Price,
                    Quantity = basket.Quantity,
                    ProductId = basket.ProductId,
                    ProductName = basket.Product?.ProductTranslates?
                    .FirstOrDefault(f => f.LanguageCulture == culture).ProductName,
                    ApplicationUserId = basket.ApplicationUserId,
                    OrganizationProductId = basket.OrganizationProductId,
                    OrganizationName = basket.OrganizationProduct?.Organization?.Name
                });
            }

            return basketListDtos;
        }
    }
}
