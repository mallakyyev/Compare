using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Models.Catalog
{
    public class CategoryPanelAndProduct
    {
        public int CategoryPanelId { get; set; }

        public int ProductId { get; set; }

        public CategoryPanel CategoryPanel { get; set; }

        public Product Product { get; set; }
    }
}
