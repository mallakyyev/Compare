using Compare.BLL.DTOs.Info;
using Compare.DAL.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.Services.Info
{
    public interface IInformationService
    {
        Task CreateInformationAsync(CreateInformationDTO modelDTO);

        Task EditInformationAsync(EditInformationDTO modelDTO);

        Task<EditInformationDTO> GetEditInformationAsync(InformationStatus informationStatus);

        Task<InformationListDTO> GetInformationListAsync(InformationStatus informationStatus);
    }
}
