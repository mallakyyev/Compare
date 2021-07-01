using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Models.Catalog
{
    public class CategoryPanelTranslate
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LanguageCulture { get; set; }

        public int CategoryPanelId { get; set; }

        public CategoryPanel CategoryPanel { get; set; }
    }
}
