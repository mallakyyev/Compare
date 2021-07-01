using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.Info
{
    public record InformationTranslateDTO
    {
        public int Id { get; set; }

        public string LanguageCulture { get; set; }

        public string Address { get; set; }

        public string Description { get; set; }

        public int InformationId { get; set; }
    }
}
