using Compare.BLL.DTOs.Commentary.StoreCommentary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.Services.StoreCommentary
{
    public interface IStoreCommentService
    {
        IEnumerable<StoreCommentListDto> GetAllStoreComments();

        IEnumerable<StoreCommentListDto> GetAllStoreCommentsByUser(string userId);

        Task CreateStoreCommentAsync(StoreCommentCreateDto modelDTO);

        Task EditStoreCommentAsync(StoreCommentEditDto modelDTO);

        Task RemoveStoreCommentAsync(int id);

        Task<StoreCommentEditDto> GetStoreCommentAsync(int id);
    }
}
