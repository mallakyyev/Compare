using Compare.BLL.DTOs.ProductOption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.Services.ProductOption
{
    public interface IProductOptionService
    {
        IEnumerable<ProductOptionListDTO> GetAllproductOption();

        Task CreateProductOptionAsync(CreateProductOptionDTO modelDTO);

        Task EditProductOptionAsync(EditProductOptionDTO modelDTO);

        Task RemoveProductOptionAsync(int id);

        Task<EditProductOptionDTO> GetEditProductOptionAsync(int id);
    }
}
