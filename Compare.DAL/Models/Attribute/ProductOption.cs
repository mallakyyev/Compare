using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Models.Attribute
{
    public class ProductOption
    {
        public int Id { get; set; }

        public ICollection<ProductOptionTranslate> ProductOptionTranslates { get; set; }

        public ICollection<ProductAttributeTemplateAndProductOption> ProductAttributeTemplateAndProductOptions { get; set; }
    }
}
