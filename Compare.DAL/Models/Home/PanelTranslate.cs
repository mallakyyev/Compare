using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Models.Home
{
    public class PanelTranslate
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LanguageCulture { get; set; }

        public int PanelId { get; set; }

        public Panel Panel { get; set; }
    }
}
