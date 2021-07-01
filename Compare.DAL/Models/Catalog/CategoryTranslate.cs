using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Models.Catalog
{
    public class CategoryTranslate
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public string Name { get; set; }

        public string MetaTitle { get; set; }

        public string MetaDescription { get; set; }

        public string LanguageCulture { get; set; }

        public Category Category { get; set; }
    }
}
