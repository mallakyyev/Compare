using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.Organization
{
    public record CreateOrganizationApiDTO
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int[] CategoriesId { get; set; }

        [Required]
        public int OrganizationId { get; set; }

        [Required]
        public string UrlApi { get; set; }
    }
}
