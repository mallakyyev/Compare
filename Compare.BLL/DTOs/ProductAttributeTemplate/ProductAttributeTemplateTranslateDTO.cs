using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.ProductAttributeTemplate
{
    public record ProductAttributeTemplateTranslateDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LanguageCulture { get; set; }

        public int ProductAttributeTemplateId { get; set; }

        public ProductAttributeTemplateDTO ProductAttributeTemplate { get; set; }
    }
}
