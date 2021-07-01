using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Compare.BLL.DTOs.Manufacture
{
    public record ManufactureDTO
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Image { get; set; }

        public int DisplayOrder { get; set; }

        //public ICollection<ProductDTO> Products { get; set; }
    }
}
