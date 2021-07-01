using Compare.BLL.DTOs.Commentary.ProductCommentary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.Services.ProductCommentary
{
    public interface IProductCommentService
    {
        IEnumerable<ProductCommentListDto> GetAllProductComments();

        IEnumerable<ProductCommentListDto> GetAllProductCommentsByUser(string userId);

        Task CreateProductCommentAsync(ProductCommentCreateDto modelDTO);

        Task EditProductCommentAsync(ProductCommentEditDto modelDTO);

        Task RemoveProductCommentAsync(int id);

        Task<ProductCommentEditDto> GetProductCommentAsync(int id);
    }
}
