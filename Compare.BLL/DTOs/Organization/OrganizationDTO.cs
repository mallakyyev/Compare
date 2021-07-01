using Compare.BLL.DTOs.Bookmarks;
using Compare.BLL.DTOs.Commentary.StoreCommentary;
using Compare.BLL.DTOs.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.Organization
{
    public record OrganizationDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Logo { get; set; }

        public string Description { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Site { get; set; }

        public string ApplicationUserId { get; set; }

        public ApplicationUserDTO ApplicationUser { get; set; }

        public ICollection<StoreCommentListDto> StoreComments { get; set; }

        public ICollection<BookmarkDto> Bookmarks { get; set; }
    }
}
