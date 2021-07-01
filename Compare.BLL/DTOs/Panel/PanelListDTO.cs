﻿using Compare.BLL.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.Panel
{
    public record PanelListDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int DisplayOrder { get; set; }

        public bool IsPublish { get; set; }

        public ICollection<ProductDTO> Products { get; set; }
    }
}
