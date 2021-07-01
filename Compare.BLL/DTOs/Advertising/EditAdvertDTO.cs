﻿using Compare.DAL.Models.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.Advertising
{
    public record EditAdvertDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public AdvertPlaceStatus AdvertPlaceStatus { get; set; }

        [Required]
        public PagePlaceStatus PagePlaceStatus { get; set; }

        public int? CategoryId { get; set; }

        [Required]
        public string Image { get; set; }

        public IFormFile FormFile { get; set; }

        [Required]
        public string Link { get; set; }

        [Required]
        public DateTime DateStart { get; set; }

        [Required]
        public DateTime DateEnd { get; set; }

        [Required]
        public int DisplayOrder { get; set; }

        [Required]
        public bool IsPublish { get; set; }

        public ICollection<AdvertTranslateDTO> AdvertTranslates { get; set; }
    }
}
