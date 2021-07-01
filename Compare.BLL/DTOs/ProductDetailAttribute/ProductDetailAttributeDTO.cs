using Compare.BLL.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.ProductDetailAttribute
{
    public record ProductDetailAttributeDTO
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public ProductDTO Product { get; set; }

        public ICollection<ProductDetailAttributeTranslateDTO> ProductDetailAttributeTranslates { get; set; }
    }
}
