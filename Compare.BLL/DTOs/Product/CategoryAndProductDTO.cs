using Compare.BLL.DTOs.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.Product
{
    public record CategoryAndProductDTO
    {
        public int CategoryId { get; set; }
        public int ProductId { get; set; }

        public CategoryDTO Category { get; set; }
        public ProductDTO Product { get; set; }
    }
}
