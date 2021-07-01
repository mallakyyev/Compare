using Compare.DAL.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.Info
{
    public record EditInformationDTO
    {
        public int Id { get; set; }

        public ICollection<InformationTranslateDTO> InformationTranslates { get; set; }

        public InformationStatus? InformationStatus { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }
    }
}
