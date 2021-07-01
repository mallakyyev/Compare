using Compare.BLL.DTOs.Banner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.Services.Banner
{
    public interface IBannerService
    {
        IEnumerable<BannerListDTO> GetAllBanners();

        Task CreateBannerAsync(CreateBannerDTO modelDTO);

        Task EditBannerAsync(EditBannerDTO modelDTO);

        Task RemoveBannerAsync(int id);

        Task<EditBannerDTO> GetEditBannerAsync(int id);

        IEnumerable<BannerListDTO> GetAllPublishBanners();
    }
}
