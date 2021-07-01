using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Models.OnlineMarkets
{
    public class Yuzharyt
    {
        public int p_id { get; set; }

        public string p_name_ru { get; set; }

        public string p_name_en { get; set; }

        public string p_name_tm { get; set; }

        public double p_price_1 { get; set; }

        public int p_quantity { get; set; }

        public string p_desc_ru { get; set; }

        public string p_desc_en { get; set; }

        public string p_desc_tm { get; set; }

        public string p_img { get; set; }

        public string p_unit { get; set; }

        public string p_stock { get; set; }
    }
}
