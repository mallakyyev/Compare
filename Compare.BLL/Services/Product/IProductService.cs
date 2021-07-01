using Compare.BLL.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.Services.Product
{
    public interface IProductService
    {
        IEnumerable<ProductDTO> GetAllProducts();

        Task CreateProductAsync(CreateProductDTO modelDTO);

        Task CreateCopyProductAsync(CreateProductDTO modelDTO);

        Task EditProductAsync(EditProductDTO modelDTO);

        Task RemoveProductAsync(int id);

        Task<EditProductDTO> GetProductAsync(int id);

        IEnumerable<ProductDTO> GetAllProductsOrganizationSubscription(int organizationId);


        IEnumerable<ProductDTO> GetProductCategoryList(int categoryId);

        Task<ProductDTO> ProductDetailAsync(int productId, string userId);

        IEnumerable<ProductDTO> GetSearchProducts(string text);


        IEnumerable<ProductMediaDTO> GetProductMedias(int productId);

        Task RemoveProductMediaAsync(int id);
    }
}
