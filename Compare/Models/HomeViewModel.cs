using Compare.BLL.DTOs.Advertising;
using Compare.BLL.DTOs.Banner;
using Compare.BLL.DTOs.Catalog;
using Compare.BLL.DTOs.Panel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compare.Models
{
    public class HomeViewModel
    {
        public IEnumerable<CategoryDTO> ParentCategories { get; set; }

        public IEnumerable<BannerListDTO> BannerList { get; set; }

        public IEnumerable<PanelListDTO> PannelList { get; set; }

        public IEnumerable<AdvertListDTO> AdvertList { get; set; }
    }
}
