using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Models.Home
{
    public class Panel
    {
        public int Id { get; set; }

        public int DisplayOrder { get; set; }

        public bool IsPublish { get; set; }

        public ICollection<PanelTranslate> PanelTranslates { get; set; }

        public ICollection<PanelAndProduct> PanelAndProducts { get; set; }
    }
}
