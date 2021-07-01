using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.Product
{
    public record ProductMediaDTO
    {
        public int Id { get; set; }

        public string Image { get; set; }

        public int ProductId { get; set; }

        public ProductDTO Product { get; set; }
    }
}
