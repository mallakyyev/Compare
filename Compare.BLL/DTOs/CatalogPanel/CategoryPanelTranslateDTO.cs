using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.CatalogPanel
{
    public record CategoryPanelTranslateDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LanguageCulture { get; set; }

        public int CategoryPanelId { get; set; }

        public CategoryPanelDTO CategoryPanel { get; set; }
    }
}
