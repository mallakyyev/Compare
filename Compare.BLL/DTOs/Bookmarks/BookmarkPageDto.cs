using Compare.BLL.DTOs.Organization;
using System.Collections.Generic;

namespace Compare.BLL.DTOs.Bookmarks
{
    public record BookmarkPageDto
    {
        public ICollection<BookmarkListDto> BookmarkLists { get; set; }

        public ICollection<OrganizationProductListDTO> OrganizationProductList { get; set; }
    }
}