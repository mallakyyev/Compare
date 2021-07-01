using Compare.DAL.Models.Company;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Models.Commentary
{
    public class StoreComment : Comment
    {
        public int OrganizationId { get; set; }

        public Organization Organization { get; set; }
    }
}
