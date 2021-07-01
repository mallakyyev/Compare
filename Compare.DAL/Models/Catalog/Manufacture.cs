using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Models.Catalog
{
    public class Manufacture
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        public int DisplayOrder { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
