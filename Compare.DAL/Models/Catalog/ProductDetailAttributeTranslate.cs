using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Models.Catalog
{
    public class ProductDetailAttributeTranslate
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }

        public string LanguageCulture { get; set; }

        public int ProductDetailAttributeId { get; set; }

        public ProductDetailAttribute ProductDetailAttribute { get; set; }
    }
}
