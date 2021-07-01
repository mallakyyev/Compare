using Compare.BLL.DTOs.ProductOption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.ProductAttributeTemplate
{
    public record ProductAttributeTemplateAndProductOptionDTO
    {
        public int ProductAttributeTemplateId { get; set; }

        public int ProductOptionId { get; set; }

        public ProductAttributeTemplateDTO ProductAttributeTemplate { get; set; }

        public ProductOptionDTO ProductOption { get; set; }
    }
}
