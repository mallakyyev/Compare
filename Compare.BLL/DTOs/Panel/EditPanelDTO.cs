using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.Panel
{
    public record EditPanelDTO
    {
        public int Id { get; set; }

        public ICollection<PanelTranslateDTO> PanelTranslates { get; set; }

        public ICollection<int> ProductsId { get; set; }

        [Required]
        public int DisplayOrder { get; set; }

        [Required]
        public bool IsPublish { get; set; }
    }
}
