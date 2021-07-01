using Compare.BLL.DTOs.Manufacture;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.Services.Manufacture
{
    public interface IManufactureService
    {
        IEnumerable<ManufactureDTO> GetAllManufacture();

        Task CreateManufacture(CreateManufactureDTO modelDTO);

        Task EditManufacture(ManufactureDTO modelDTO);

        Task RemoveManufacture(int id);


        Task<IEnumerable<ManufactureDTO>> GetManufactureProductsAsync(IEnumerable<int> manufactureId);
    }
}
