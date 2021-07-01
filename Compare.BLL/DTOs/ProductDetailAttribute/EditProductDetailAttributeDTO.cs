using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.ProductDetailAttribute
{
    public record EditProductDetailAttributeDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int ProductId { get; set; }

        public ICollection<ProductDetailAttributeTranslateDTO> ProductDetailAttributeTranslates { get; set; }
    }
}
