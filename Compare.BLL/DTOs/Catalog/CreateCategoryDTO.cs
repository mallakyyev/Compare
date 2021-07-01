using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.Catalog
{
    public record CreateCategoryDTO
    {
        public ICollection<CategoryTranslateDTO> CategoryTranslates { get; set; }

        [Required]
        public int DisplayOrder { get; set; }

        [Required]
        public bool Published { get; set; }

        public int? ParentCategoryId { get; set; }
    }
}
