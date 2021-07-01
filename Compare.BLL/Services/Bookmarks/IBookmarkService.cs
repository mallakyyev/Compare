using Compare.BLL.DTOs.Bookmarks;
using Compare.DAL.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.Services.Bookmarks
{
    public interface IBookmarkService
    {
        BookmarkPageDto GetAllBookmarksByUserId(string userId);

        Task<ModelStatus> CreateBookmarkAsync(BookmarkCreateDto modelDTO);

        Task RemoveBookmarkAsync(int id);

        Task RemoveAllBookmarksByUserId(string userId);

        Task<bool> CheckBookmark(ClaimsPrincipal claimsPrincipal, int productId, int organizationId);
    }
}
