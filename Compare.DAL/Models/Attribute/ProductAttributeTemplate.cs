using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Models.Attribute
{
    public class ProductAttributeTemplate
    {
        public int Id { get; set; }

        public ICollection<ProductAttributeTemplateTranslate> ProductAttributeTemplateTranslates { get; set; }

        public ICollection<ProductAttributeTemplateAndProductOption> ProductAttributeTemplateAndProductOptions { get; set; }
    }
}
