using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Models.Catalog
{
    public class CategoryAndProduct
    {
        public int CategoryId { get; set; }
        public int ProductId { get; set; }

        public Category Category { get; set; }
        public Product Product { get; set; }
    }
}
