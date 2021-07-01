using Compare.BLL.DTOs.Bookmarks;
using Compare.BLL.DTOs.Commentary;
using Compare.BLL.DTOs.Organization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.User
{
    public record ApplicationUserDTO
    {
        public string Id { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName { get; set; }

        public int? OrganizationId { get; set; }

        public OrganizationDTO Organization { get; set; }

        public ICollection<CommentDto> Comments { get; set; }

        public ICollection<BookmarkDto> Bookmarks { get; set; }
    }
}
