using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.Organization
{
    public record EditOrganizationApiDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public ICollection<int> CategoriesId { get; set; }

        [Required]
        public int OrganizationId { get; set; }

        [Required]
        public string UrlApi { get; set; }
    }
}
