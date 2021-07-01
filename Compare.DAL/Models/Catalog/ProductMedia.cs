using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Models.Catalog
{
    public class ProductMedia
    {
        public int Id { get; set; }

        public string Image { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }
    }
}
