using Compare.BLL.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.CatalogPanel
{
    public record CategoryPanelAndProductDTO
    {
        public int CategoryPanelId { get; set; }

        public int ProductId { get; set; }

        public CategoryPanelDTO CategoryPanel { get; set; }

        public ProductDTO Product { get; set; }
    }
}
