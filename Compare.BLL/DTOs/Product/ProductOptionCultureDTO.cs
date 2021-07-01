using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.Product
{
    public record ProductOptionCultureDTO
    {
        public string Name { get; set; }
        public string LanguageCulture { get; set; }
    }
}
