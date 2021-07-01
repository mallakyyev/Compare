using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.Panel
{
    public record PanelDTO
    {
        public int Id { get; set; }

        public int DisplayOrder { get; set; }

        public bool IsPublish { get; set; }

        public ICollection<PanelTranslateDTO> PanelTranslates { get; set; }

        public ICollection<PanelAndProductDTO> PanelAndProducts { get; set; }
    }
}
