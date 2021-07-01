using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Models.Catalog
{
    public class ProductDetailAttribute
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }

        public ICollection<ProductDetailAttributeTranslate> ProductDetailAttributeTranslates { get; set; }
    }
}
