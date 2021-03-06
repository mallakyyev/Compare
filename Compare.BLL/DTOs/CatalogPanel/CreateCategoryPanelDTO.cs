using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.CatalogPanel
{
    public record CreateCategoryPanelDTO
    {
        [Required]
        public int CategoryId { get; set; }

        [Required]
        public int[] ProductsId { get; set; }

        [Required]
        public int DisplayOrder { get; set; }

        public bool IsPublish { get; set; }

        public ICollection<CategoryPanelTranslateDTO> CategoryPanelTranslates { get; set; }
    }
}
