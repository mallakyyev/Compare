using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.DTOs.Bookmarks
{
    public record BookmarkCreateDto
    {
        public string ApplicationUserId { get; set; }

        [Required]
        public int ProductId { get; set; }
    }
}
