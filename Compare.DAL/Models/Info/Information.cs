using Compare.DAL.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Models.Info
{
    public class Information
    {
        public int Id { get; set; }

        public InformationStatus? InformationStatus { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public ICollection<InformationTranslate> InformationTranslates { get; set; }
    }
}
