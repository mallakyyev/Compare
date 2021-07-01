using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.Commentary.ProductCommentary
{
    public record ProductCommentListDto : CommentListDto
    {
        public int ProductId { get; set; }
    }
}
