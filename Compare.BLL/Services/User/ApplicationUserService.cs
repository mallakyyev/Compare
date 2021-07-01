using AutoMapper;
using Compare.BLL.DTOs.User;
using Compare.DAL.Models.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.Services.User
{
    public class ApplicationUserService : IApplicationUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IMapper _mapper;

        public ApplicationUserService(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager,
            IMapper mapper)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _mapper = mapper;
        }

        public async Task CreateApplicationUserAsync(CreateApplicationUserDTO model)
        {
            var user = _mapper.Map<ApplicationUser>(model);
            user.FullName = $"{user.FirstName} {user.LastName}";
            user.EmailConfirmed = true;

            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, model.Role);
            }
        }

        public async Task EditApplicationUserAsync(EditApplicationUserDTO model)
        {
            var user = await _userManager.Users.SingleOrDefaultAsync(s => s.Id == model.Id);
            user.UserName = model.UserName;
            user.Email = model.Email;
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.FullName = $"{user.FirstName} {user.LastName}";
            user.EmailConfirmed = true;
            user.PhoneNumber = model.PhoneNumber;
            user.OrganizationId = model.OrganizationId;

            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                var selectedRoleNames = await _userManager.GetRolesAsync(user);
                if (model.Role != selectedRoleNames.FirstOrDefault())
                {
                    await _userManager.RemoveFromRolesAsync(user, selectedRoleNames);
                    await _userManager.AddToRoleAsync(user, model.Role);
                }
            }
        }

        public IEnumerable<ApplicationUserListDTO> GetAllUsers()
        {
            var appUsers = _userManager.Users.Where(p => p.UserName != "Administrator").Include(i => i.Organization).AsQueryable();
            var users = _mapper.Map<IEnumerable<ApplicationUserListDTO>>(appUsers);
            return users;
        }

        public async Task<IdentityResult> ChangePasswordAsync(ChangePasswordDTO model)
        {
            var user = await _userManager.FindByIdAsync(model.Id);
            if(user != null)
            {
                var Code = await _userManager.GeneratePasswordResetTokenAsync(user);
                var result = await _userManager.ResetPasswordAsync(user, Code, model.Password);
                return result;
            }
            return null;
        }

        public async Task RemoveApplicationUserAsync(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if(user != null)
            {
                await _userManager.DeleteAsync(user);
            }
        }

        public async Task<EditApplicationUserDTO> GetEditApplicationUserAsync(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            var editApplicationUserDTO = _mapper.Map<EditApplicationUserDTO>(user);

            return editApplicationUserDTO;
        }

        public async Task<IList<string>> GetRolesAsync(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            return await _userManager.GetRolesAsync(user);
        }

        public async Task<ApplicationUser> UserFindByIdAsync(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            return user;
        }
    }
}
