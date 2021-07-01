using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Models.Attribute
{
    public class ProductOptionTranslate
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LanguageCulture { get; set; }

        public int ProductOptionId { get; set; }

        public ProductOption ProductOption { get; set; }
    }
}
