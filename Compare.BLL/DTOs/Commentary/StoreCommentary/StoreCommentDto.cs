using Compare.BLL.DTOs.Organization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.Commentary.StoreCommentary
{
    public record StoreCommentDto : CommentDto
    {
        public int OrganizationId { get; set; }

        public OrganizationDTO Organization { get; set; }
    }
}
