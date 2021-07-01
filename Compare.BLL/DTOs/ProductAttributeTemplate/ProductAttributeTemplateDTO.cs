using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.ProductAttributeTemplate
{
    public record ProductAttributeTemplateDTO
    {
        public int Id { get; set; }

        public ICollection<ProductAttributeTemplateTranslateDTO> ProductAttributeTemplateTranslates { get; set; }

        public ICollection<ProductAttributeTemplateAndProductOptionDTO> ProductAttributeTemplateAndProductOptions { get; set; }
    }
}
