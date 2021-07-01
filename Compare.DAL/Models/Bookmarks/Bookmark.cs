using Compare.DAL.Models.Catalog;
using Compare.DAL.Models.Company;
using Compare.DAL.Models.User;

namespace Compare.DAL.Models.Bookmarks
{
    /// <summary>
    /// Закладка
    /// </summary>
    public class Bookmark
    {
        public int Id { get; set; }

        public string ApplicationUserId { get; set; }

        public int ProductId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public Product Product { get; set; }
    }
}
