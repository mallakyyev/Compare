using Compare.BLL.DTOs.Panel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.Services.Panel
{
    public interface IPanelService
    {
        IEnumerable<PanelListDTO> GetAllPanels();

        Task CreatePanelAsync(CreatePanelDTO modelDTO);

        Task EditPanelAsync(EditPanelDTO modelDTO);

        Task RemovePanelAsync(int id);

        Task<EditPanelDTO> GetEditPanelAsync(int id);


        IEnumerable<PanelListDTO> GetAllPublishPanels();
    }
}
