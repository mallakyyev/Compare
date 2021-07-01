using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Models.Attribute
{
    public class ProductAttributeTemplateAndProductOption
    {
        public int ProductAttributeTemplateId { get; set; }

        public int ProductOptionId { get; set; }

        public ProductAttributeTemplate ProductAttributeTemplate { get; set; }

        public ProductOption ProductOption { get; set; }
    }
}
