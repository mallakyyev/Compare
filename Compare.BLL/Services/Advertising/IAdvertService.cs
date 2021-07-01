using Compare.BLL.DTOs.Advertising;
using Compare.DAL.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.Services.Advertising
{
    public interface IAdvertService
    {
        IEnumerable<AdvertListDTO> GetAllAdverts();

        IEnumerable<AdvertListDTO> GetFilterAdverts(PagePlaceStatus pagePlaceStatus, int? categoryId);

        Task CreateAdvertAsync(CreateAdvertDTO modelDTO);

        Task EditAdvertAsync(EditAdvertDTO modelDTO);

        Task RemoveAdvertAsync(int id);

        Task<EditAdvertDTO> GetEditAdvertAsync(int id);
    }
}
