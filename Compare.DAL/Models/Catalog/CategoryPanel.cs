using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Models.Catalog
{
    public class CategoryPanel
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public int DisplayOrder { get; set; }

        public bool IsPublish { get; set; }

        public Category Category { get; set; }

        public ICollection<CategoryPanelTranslate> CategoryPanelTranslates { get; set; }

        public ICollection<CategoryPanelAndProduct> CategoryPanelAndProducts { get; set; }
    }
}
