using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Models.Info
{
    public class InformationTranslate
    {
        public int Id { get; set; }

        public string LanguageCulture { get; set; }

        public string Address { get; set; }

        public string Description { get; set; }

        public int InformationId { get; set; }

        public Information Information { get; set; }
    }
}
