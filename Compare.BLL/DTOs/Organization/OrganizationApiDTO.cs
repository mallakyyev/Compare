using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.Organization
{
    public record OrganizationApiDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int OrganizationId { get; set; }

        public string UrlApi { get; set; }

        public OrganizationDTO Organization { get; set; }
    }
}
