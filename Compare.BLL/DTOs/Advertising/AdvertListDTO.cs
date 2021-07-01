using Compare.DAL.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.Advertising
{
    public record AdvertListDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        public AdvertPlaceStatus AdvertPlaceStatus { get; set; }

        public PagePlaceStatus PagePlaceStatus { get; set; }

        public string Link { get; set; }

        public DateTime DateStart { get; set; }

        public DateTime DateEnd { get; set; }

        public int DisplayOrder { get; set; }

        public bool IsPublish { get; set; }
    }
}
