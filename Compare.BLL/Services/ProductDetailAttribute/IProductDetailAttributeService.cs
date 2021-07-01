using Compare.BLL.DTOs.ProductDetailAttribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.Services.ProductDetailAttribute
{
    public interface IProductDetailAttributeService
    {
        Task CreateProductDetailAttributeAsync(CreateProductDetailAttributeDTO modelDTO);

        Task EditProductDetailAttributeAsync(EditProductDetailAttributeDTO modelDTO);

        Task<EditProductDetailAttributeDTO> GetEditProductDetailAttributeAsync(int id);

        Task FindProductDetailAttributeAndCreateCopyAsync(int productId, int newProductId);

        Task UpdateFieldProductDetailAttributeId(int productId, int productDetailAttributeId);
    }
}
