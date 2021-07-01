using AutoMapper;
using Compare.BLL.DTOs.Panel;
using Compare.BLL.DTOs.Product;
using Compare.DAL.Data;
using Compare.DAL.Models.Home;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using panel = Compare.DAL.Models.Home;

namespace Compare.BLL.Services.Panel
{
    public class PanelService : IPanelService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public PanelService(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task CreatePanelAsync(CreatePanelDTO modelDTO)
        {
            List<PanelAndProduct> panelAndProducts = new List<PanelAndProduct>();

            panel.Panel pl = _mapper.Map<panel.Panel>(modelDTO);
            foreach (int prdId in modelDTO.ProductsId)
            {
                panelAndProducts.Add(new PanelAndProduct()
                {
                    PanelId = pl.Id,
                    ProductId = prdId
                });
            }
            pl.PanelAndProducts = panelAndProducts;

            await _dbContext.Panels.AddAsync(pl);
            await _dbContext.SaveChangesAsync();
        }

        public async Task EditPanelAsync(EditPanelDTO modelDTO)
        {
            var pl = await _dbContext.Panels.Include(p => p.PanelAndProducts).AsSplitQuery()
                .Include(p => p.PanelTranslates).AsSplitQuery()
                .FirstOrDefaultAsync(p => p.Id == modelDTO.Id);

            pl.PanelTranslates.Clear();
            pl.PanelAndProducts.Clear();

            pl.PanelTranslates = modelDTO.PanelTranslates
                .Select(p => new PanelTranslate
                {
                    LanguageCulture = p.LanguageCulture,
                    Name = p.Name,
                    PanelId = p.PanelId
                }).ToList();

            pl.PanelAndProducts = modelDTO.ProductsId
                .Select(p => new PanelAndProduct
                {
                    ProductId = p,
                    PanelId = pl.Id
                }).ToList();

            pl.DisplayOrder = modelDTO.DisplayOrder;
            pl.IsPublish = modelDTO.IsPublish;

            _dbContext.Update(pl);
            await _dbContext.SaveChangesAsync();
        }

        public IEnumerable<PanelListDTO> GetAllPanels()
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            var pls = _dbContext.Panels.AsQueryable();
            var result = _dbContext.PanelTranslates
                .Where(p => p.LanguageCulture == culture).Join(pls, p => p.PanelId, k => k.Id,
                (p, k) => new PanelListDTO
                {
                    Id = k.Id,
                    Name = p.Name,
                    DisplayOrder = k.DisplayOrder,
                    IsPublish = k.IsPublish
                });
            return result;
        }

        public IEnumerable<PanelListDTO> GetAllPublishPanels()
        {
            string culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            List<PanelListDTO> panelListDTOs = new List<PanelListDTO>();

            var pls = _dbContext.Panels
                .Include(i => i.PanelAndProducts).ThenInclude(t => t.Product)
                .ThenInclude(t => t.ProductTranslates).AsSplitQuery()
                .Include(i => i.PanelAndProducts).ThenInclude(t => t.Product).AsSplitQuery()
                .Include(i => i.PanelTranslates).AsSplitQuery()
                .Where(p => p.IsPublish == true);
            //var result = _dbContext.PanelTranslates
            //    .Where(p => p.LanguageCulture == culture).Join(pls, p => p.PanelId, k => k.Id,
            //    (p, k) => new PanelListDTO
            //    {
            //        Id = k.Id,
            //        Name = p.Name,
            //        DisplayOrder = k.DisplayOrder,
            //        IsPublish = k.IsPublish
            //    });

            foreach(var pnl in pls)
            {
                var products = new List<ProductDTO>();

                foreach(var product in pnl.PanelAndProducts)
                {
                    products.Add(new ProductDTO()
                    {
                        Id = product.Product.Id,
                        ProductName = product.Product.ProductTranslates.SingleOrDefault(s => s.LanguageCulture == culture).ProductName,
                        Image = product.Product.Image,
                        MinPrice = product.Product.MinPrice,
                        DisplayOrder = product.Product.DisplayOrder
                    });
                }

                panelListDTOs.Add(new PanelListDTO()
                {
                    Id = pnl.Id,
                    Name = pnl.PanelTranslates.SingleOrDefault(s => s.LanguageCulture == culture).Name,
                    DisplayOrder = pnl.DisplayOrder,
                    IsPublish = pnl.IsPublish,
                    Products = products
                });
            }

            return panelListDTOs;
        }

        public async Task<EditPanelDTO> GetEditPanelAsync(int id)
        {
            panel.Panel pl = await _dbContext.Panels
                .Include(i => i.PanelTranslates).AsSplitQuery()
                .Include(i => i.PanelAndProducts).AsSplitQuery()
                .SingleOrDefaultAsync(s => s.Id == id);
            EditPanelDTO editPanelDTO = _mapper.Map<EditPanelDTO>(pl);
            return editPanelDTO;
        }

        public async Task RemovePanelAsync(int id)
        {
            panel.Panel pl = await _dbContext.Panels.FindAsync(id);
            _dbContext.Panels.Remove(pl);
            await _dbContext.SaveChangesAsync();
        }
    }
}
