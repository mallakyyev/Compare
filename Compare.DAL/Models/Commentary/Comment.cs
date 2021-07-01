using Compare.DAL.Models.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Models.Commentary
{
    public class Comment
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime PublicateDate { get; set; }

        public bool IsPublish { get; set; }

        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
    }
}
