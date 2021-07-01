using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.Catalog
{
    public record CategoryTranslateDTO
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string MetaTitle { get; set; }

        [Required]
        public string MetaDescription { get; set; }

        public int CategoryId { get; set; }

        [Required]
        public string LanguageCulture { get; set; }
    }
}
