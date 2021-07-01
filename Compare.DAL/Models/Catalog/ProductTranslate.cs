using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Models.Catalog
{
    public class ProductTranslate
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string ShortDescription { get; set; }

        public string FullDescription { get; set; }

        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }

        public string LanguageCulture { get; set; }

        public Product Product { get; set; }
    }
}
