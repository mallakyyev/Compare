using Compare.BLL.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.Bookmarks
{
    public record BookmarkListDto
    {
        public int Id { get; set; }

        public string ApplicationUserId { get; set; }

        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string ProductImage { get; set; }

        public double Price { get; set; }

        public string OrganizationProductLink { get; set; }
    }
}
