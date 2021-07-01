using AutoMapper;
using Compare.BLL.DTOs.Bookmarks;
using Compare.BLL.DTOs.Organization;
using Compare.BLL.DTOs.Product;
using Compare.DAL.Data;
using Compare.DAL.Models.Bookmarks;
using Compare.DAL.Models.Enums;
using Compare.DAL.Models.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.Services.Bookmarks
{
    public class BookmarkService : IBookmarkService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;

        public BookmarkService(ApplicationDbContext dbContext, IMapper mapper, UserManager<ApplicationUser> userManager)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task<bool> CheckBookmark(ClaimsPrincipal claimsPrincipal, int productId, int organizationId)
        {
            var user = await _userManager.GetUserAsync(claimsPrincipal);
            var bookmark = await _dbContext.Bookmarks
                .FirstOrDefaultAsync(p => p.ApplicationUserId == user.Id && p.ProductId == productId);
            if (bookmark != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<ModelStatus> CreateBookmarkAsync(BookmarkCreateDto modelDTO)
        {
            try
            {
                var findCopy = await _dbContext.Bookmarks
                    .FirstOrDefaultAsync(p => p.ProductId == modelDTO.ProductId);
                if (findCopy != null)
                {
                    return ModelStatus.Duplicate;
                }
                else
                {
                    var bookmark = _mapper.Map<Bookmark>(modelDTO);
                    await _dbContext.Bookmarks.AddAsync(bookmark);
                    await _dbContext.SaveChangesAsync();

                    return ModelStatus.Success;
                }
            }
            catch (Exception ex)
            {
                return ModelStatus.Error;
            }
        }

        public BookmarkPageDto GetAllBookmarksByUserId(string userId)
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            BookmarkPageDto bookmarkPageDto = new BookmarkPageDto();
            bookmarkPageDto.BookmarkLists = new List<BookmarkListDto>();
            bookmarkPageDto.OrganizationProductList = new List<OrganizationProductListDTO>();
            //List<BookmarkListDto> bookmarkListDtos = new List<BookmarkListDto>();
            //List<OrganizationProductListDTO> organizationProductListDTOs = new List<OrganizationProductListDTO>();

            var bookmarks = _dbContext.Bookmarks.Where(p => p.ApplicationUserId == userId)
                .Include(i => i.Product).ThenInclude(t => t.ProductTranslates).AsQueryable()
                .Include(i => i.Product).ThenInclude(t => t.OrganizationProducts).ThenInclude(t => t.Organization).AsQueryable();

            foreach (var bookmark in bookmarks)
            {
                bookmarkPageDto.BookmarkLists.Add(new BookmarkListDto
                {
                    Id = bookmark.Id,
                    ApplicationUserId = bookmark.ApplicationUserId,
                    ProductId = bookmark.ProductId,
                    ProductName = bookmark.Product?.ProductTranslates.FirstOrDefault(f => f.LanguageCulture == culture)?.ProductName,
                    ProductImage = bookmark.Product.Image
                });
                foreach(var organizationProduct in bookmark.Product?.OrganizationProducts)
                {
                    bookmarkPageDto.OrganizationProductList.Add(new OrganizationProductListDTO
                    {
                        Id = organizationProduct.Id,
                        OrganizationId = organizationProduct.OrganizationId,
                        Price = organizationProduct.Price,
                        OrganizationName = organizationProduct.Organization.Name,
                        InStock = organizationProduct.InStock,
                        OrganizationProductUrl = organizationProduct.OrganizationProductUrl,
                        OrganizationLogo = organizationProduct.Organization.Logo,
                        ProductId = organizationProduct.ProductId
                    });
                }
                
            }

            return bookmarkPageDto;
        }

        public async Task RemoveAllBookmarksByUserId(string userId)
        {
            var bookmarks = _dbContext.Bookmarks.Where(p => p.ApplicationUserId == userId);
            if (bookmarks != null)
            {
                _dbContext.RemoveRange(bookmarks);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task RemoveBookmarkAsync(int id)
        {
            var bookmark = await _dbContext.Bookmarks.FindAsync(id);
            if (bookmark != null)
            {
                _dbContext.Bookmarks.Remove(bookmark);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
