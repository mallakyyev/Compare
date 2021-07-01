using Compare.BLL.DTOs.Cart.Basket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.Services.Cart.Basket
{
    public interface IBasketService
    {
        Task<IEnumerable<BasketListDto>> GetAllBasketProductsByApplicationUserId(string userId);

        Task CreateProductInToBasketAsync(BasketCreateDto modelDTO);
    }
}
