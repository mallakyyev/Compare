using AutoMapper;
using Compare.BLL.DTOs.Banner;
using Compare.DAL.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using banner = Compare.DAL.Models.Home;

namespace Compare.BLL.Services.Banner
{
    public class BannerService : IBannerService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IHostingEnvironment _appEnvironment;

        public BannerService(ApplicationDbContext dbContext, IMapper mapper, IHostingEnvironment appEnvironment)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _appEnvironment = appEnvironment;
        }

        public async Task CreateBannerAsync(CreateBannerDTO modelDTO)
        {
            var br = _mapper.Map<banner.Banner>(modelDTO);
            if (modelDTO.FormFile != null)
            {
                string fileName = await ImageService.UploadImage(modelDTO.FormFile, "/images/banners/", _appEnvironment);
                br.Image = fileName;
            }
            await _dbContext.Banners.AddAsync(br);
            await _dbContext.SaveChangesAsync();
        }

        public async Task EditBannerAsync(EditBannerDTO modelDTO)
        {
            banner.Banner br = _mapper.Map<banner.Banner>(modelDTO);
            if (modelDTO.FormFile != null)
            {
                if (modelDTO.Image != null)
                {
                    ImageService.DeleteImage(modelDTO.Image, "/images/banners/", _appEnvironment);
                }
                string fileName = await ImageService.UploadImage(modelDTO.FormFile, "/images/banners/", _appEnvironment);
                br.Image = fileName;
            }

            _dbContext.Banners.Update(br);
            await _dbContext.SaveChangesAsync();
        }

        public IEnumerable<BannerListDTO> GetAllBanners()
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var brs = _dbContext.Banners.AsQueryable();
            var result = _dbContext.BannerTranslates
                .Where(p => p.LanguageCulture == culture).Join(brs, p => p.BannerId, k => k.Id,
                (p, k) => new BannerListDTO
                {
                    Id = k.Id,
                    Name = p.Name,
                    Image = k.Image,
                    DateStart = k.DateStart,
                    DateEnd = k.DateEnd,
                    Link = k.Link,
                    DisplayOrder = k.DisplayOrder,
                    IsPublish = k.IsPublish
                });
            return result;
        }

        public IEnumerable<BannerListDTO> GetAllPublishBanners()
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var brs = _dbContext.Banners.Where(p => p.IsPublish == true &&
            p.DateStart <= DateTime.Now.Date && p.DateEnd >= DateTime.Now.Date);
            var result = _dbContext.BannerTranslates
                .Where(p => p.LanguageCulture == culture).Join(brs, p => p.BannerId, k => k.Id,
                (p, k) => new BannerListDTO
                {
                    Id = k.Id,
                    Name = p.Name,
                    Image = k.Image,
                    DateStart = k.DateStart,
                    DateEnd = k.DateEnd,
                    Link = k.Link,
                    DisplayOrder = k.DisplayOrder,
                    IsPublish = k.IsPublish
                });
            return result;
        }

        public async Task<EditBannerDTO> GetEditBannerAsync(int id)
        {
            var br = _mapper.Map<EditBannerDTO>(await _dbContext.Banners
                .Include(i => i.BannerTranslates)
                .SingleOrDefaultAsync(s => s.Id == id));
            return br;
        }

        public async Task RemoveBannerAsync(int id)
        {
            var br = await _dbContext.Banners.FindAsync(id);
            if (br.Image != null)
            {
                ImageService.DeleteImage(br.Image, "/images/banners/", _appEnvironment);
            }
            _dbContext.Banners.Remove(br);
            await _dbContext.SaveChangesAsync();
        }
    }
}
