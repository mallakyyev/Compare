using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.ProductOption
{
    public record ProductOptionListDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
