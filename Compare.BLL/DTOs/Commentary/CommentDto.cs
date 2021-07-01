using Compare.BLL.DTOs.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.Commentary
{
    public record CommentDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime PublicateDate { get; set; }

        public bool IsPublish { get; set; }

        public string ApplicationUserId { get; set; }

        public ApplicationUserDTO ApplicationUser { get; set; }
    }
}
