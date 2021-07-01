using Compare.BLL.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.Panel
{
    public record PanelAndProductDTO
    {
        public int ProductId { get; set; }

        public int PanelId { get; set; }

        public ProductDTO Product { get; set; }

        public PanelDTO Panel { get; set; }
    }
}
