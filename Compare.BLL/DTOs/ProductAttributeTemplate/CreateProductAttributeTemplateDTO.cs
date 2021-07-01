using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.ProductAttributeTemplate
{
    public record CreateProductAttributeTemplateDTO
    {
        public ICollection<ProductAttributeTemplateTranslateDTO> ProductAttributeTemplateTranslates { get; set; }

        public int[] ProductOptionId { get; set; }
    }
}
