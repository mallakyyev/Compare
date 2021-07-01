using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Models.OnlineMarkets
{
    public class Data
    {
        public Row data { get; set; }
    }

    public class Row
    {
        public int count { get; set; }

        public List<Yuzharyt> rows { get; set; }
    }
}
