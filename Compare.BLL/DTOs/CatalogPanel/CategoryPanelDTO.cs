using Compare.BLL.DTOs.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.CatalogPanel
{
    public record CategoryPanelDTO
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public int DisplayOrder { get; set; }

        public bool IsPublish { get; set; }

        public CategoryDTO Category { get; set; }

        public ICollection<CategoryPanelTranslateDTO> CategoryPanelTranslates { get; set; }

        public ICollection<CategoryPanelAndProductDTO> CategoryPanelAndProducts { get; set; }
    }
}
