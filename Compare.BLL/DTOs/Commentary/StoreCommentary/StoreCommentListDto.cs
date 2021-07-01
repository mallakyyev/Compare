using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.Commentary.StoreCommentary
{
    public record StoreCommentListDto : CommentListDto
    {
        public int OrganizationId { get; set; }
    }
}
