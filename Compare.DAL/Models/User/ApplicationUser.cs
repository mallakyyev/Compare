using Compare.DAL.Models.Bookmarks;
using Compare.DAL.Models.Cart;
using Compare.DAL.Models.Commentary;
using Compare.DAL.Models.Company;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Models.User
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName { get; set; }

        public int? OrganizationId { get; set; }

        public Organization Organization { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public ICollection<Bookmark> Bookmarks { get; set; }

        public ICollection<Order> Orders { get; set; }

        public ICollection<Basket> Baskets { get; set; }
    }
}
