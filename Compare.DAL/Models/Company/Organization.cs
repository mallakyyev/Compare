using Compare.DAL.Models.Bookmarks;
using Compare.DAL.Models.Commentary;
using Compare.DAL.Models.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Models.Company
{
    public class Organization
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Logo { get; set; }

        public string Description { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Site { get; set; }

        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public ICollection<OrganizationProduct> OrganizationProducts { get; set; }

        public ICollection<OrganizationApi> OrganizationApis { get; set; }

        public ICollection<OrganizationSubscription> OrganizationSubscriptions { get; set; }

        public ICollection<StoreComment> StoreComments { get; set; }

        public ICollection<Bookmark> Bookmarks { get; set; }
    }
}
