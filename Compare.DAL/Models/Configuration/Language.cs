using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Models.Configuration
{
    public class Language
    {
        public string Culture { get; set; }

        public string Name { get; set; }

        public string LanguageCode { get; set; }

        public bool Published { get; set; }
    }
}
