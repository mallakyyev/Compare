using Compare.BLL.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.Commentary.ProductCommentary
{
    public record ProductCommentDto : CommentDto
    {
        public int ProductId { get; set; }

        public ProductDTO Product { get; set; }
    }
}
