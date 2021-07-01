using Compare.BLL.DTOs.ProductAttributeTemplate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.ProductOption
{
    public record ProductOptionDTO
    {
        public int Id { get; set; }

        public ICollection<ProductOptionTranslateDTO> ProductOptionTranslates { get; set; }

        public ICollection<ProductAttributeTemplateAndProductOptionDTO> ProductAttributeTemplateAndProductOptions { get; set; }
    }
}
