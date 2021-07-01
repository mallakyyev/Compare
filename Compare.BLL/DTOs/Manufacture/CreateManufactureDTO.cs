using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.Manufacture
{
    public record CreateManufactureDTO
    {
        [Required]
        public string Name { get; set; }

        public string Image { get; set; }

        [Required]
        public int DisplayOrder { get; set; }
    }
}
