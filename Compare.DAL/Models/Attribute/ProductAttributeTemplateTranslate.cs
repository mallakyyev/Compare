using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Models.Attribute
{
    public class ProductAttributeTemplateTranslate
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LanguageCulture { get; set; }

        public int ProductAttributeTemplateId { get; set; }

        public ProductAttributeTemplate ProductAttributeTemplate { get; set; }
    }
}
