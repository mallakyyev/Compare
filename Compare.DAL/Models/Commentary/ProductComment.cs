using Compare.DAL.Models.Catalog;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Models.Commentary
{
    public class ProductComment : Comment
    {
        public int ProductId { get; set; }

        public Product Product { get; set; }
    }
}
