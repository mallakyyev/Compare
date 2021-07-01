using Compare.BLL.DTOs.Catalog;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.Configuration
{
    public record LanguageDTO
    {
        [Required]
        public string Culture { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string LanguageCode { get; set; }

        [Required]
        public bool Published { get; set; }

        public ICollection<CategoryTranslateDTO> CategoryTranslates { get; set; }
    }
}
