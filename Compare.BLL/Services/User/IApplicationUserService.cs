using Compare.BLL.DTOs.User;
using Compare.DAL.Models.User;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.Services.User
{
    public interface IApplicationUserService
    {
        IEnumerable<ApplicationUserListDTO> GetAllUsers();

        Task CreateApplicationUserAsync(CreateApplicationUserDTO model);

        Task EditApplicationUserAsync(EditApplicationUserDTO model);

        Task<IdentityResult> ChangePasswordAsync(ChangePasswordDTO model);

        Task RemoveApplicationUserAsync(string id);

        Task<EditApplicationUserDTO> GetEditApplicationUserAsync(string id);

        Task<IList<string>> GetRolesAsync(string id);

        Task<ApplicationUser> UserFindByIdAsync(string id);
    }
}
