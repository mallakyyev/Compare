using Compare.BLL.DTOs.Organization;
using Compare.BLL.DTOs.Product;
using Compare.BLL.DTOs.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.Bookmarks
{
    public record BookmarkDto
    {
        public int Id { get; set; }

        public string ApplicationUserId { get; set; }

        public int ProductId { get; set; }

        public ApplicationUserDTO ApplicationUser { get; set; }

        public ProductDTO Product { get; set; }
    }
}
