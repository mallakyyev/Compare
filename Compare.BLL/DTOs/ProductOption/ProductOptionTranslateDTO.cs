using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.ProductOption
{
    public record ProductOptionTranslateDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LanguageCulture { get; set; }

        public int ProductOptionId { get; set; }

        public ProductOptionDTO ProductOption { get; set; }
    }
}
