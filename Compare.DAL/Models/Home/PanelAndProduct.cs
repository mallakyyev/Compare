using Compare.DAL.Models.Catalog;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Models.Home
{
    public class PanelAndProduct
    {
        public int ProductId { get; set; }

        public int PanelId { get; set; }

        public Product Product { get; set; }

        public Panel Panel { get; set; }
    }
}
