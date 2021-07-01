using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.Commentary.StoreCommentary
{
    public record StoreCommentCreateDto : CommentCreateDto
    {
        public int OrganizationId { get; set; }
    }
}
