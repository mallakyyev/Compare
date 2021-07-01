using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.Organization
{
    public record CategoryOrganizationApiListDTO
    {
        public int CategoryId { get; set; }

        public int OrganizationApiId { get; set; }

        public string UrlApi { get; set; }
    }
}
