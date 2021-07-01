﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.ProductDetailAttribute
{
    public record ProductDetailAttributeTranslateDTO
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Value { get; set; }

        [Required]
        public string LanguageCulture { get; set; }

        public int ProductDetailAttributeId { get; set; }
    }
}
