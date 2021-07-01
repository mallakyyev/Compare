using Compare.DAL.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.Services.Checking
{
    public class CheckingService : ICheckingService
    {
        private readonly ApplicationDbContext _dbContext;

        public CheckingService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //public async Task CheckMinMaxPriceProducts()
        //{
        //    var products = _dbContext.Products.Where(p => p.Published == true);
        //    foreach (var product in products)
        //    {
        //        var organizationProducts = _dbContext.OrganizationProducts
        //            .Include(i => i.Organization)
        //            .ThenInclude(t => t.OrganizationSubscriptions.Where(p => p.PaymentDate <= DateTime.Now.Date && p.ExpireAt >= DateTime.Now.Date)).AsSplitQuery()
        //            .Where(p => p.ProductId == product.Id);

        //        if(organizationProducts != null)
        //        {
        //            product.MinPrice = organizationProducts.Min(p => p.Price);
        //            product.MaxPrice = organizationProducts.Max(p => p.Price);
        //            product.CountOffers = organizationProducts.Count();

        //            _dbContext.Products.Update(product);
        //            await _dbContext.SaveChangesAsync();
        //        }                
        //    }
        //}

        public async Task CheckMinMaxPriceProductById(int productId)
        {
            var product = await _dbContext.Products.SingleOrDefaultAsync(p => p.Id == productId);

            var organizationProducts = await _dbContext.OrganizationProducts
                .Include(i => i.Organization)
                .ThenInclude(t => t.OrganizationSubscriptions.Where(p => p.PaymentDate <= DateTime.Now.Date && p.ExpireAt >= DateTime.Now.Date)).AsSplitQuery()
                .Where(p => p.ProductId == productId && p.InStock == true).ToListAsync();

            if(organizationProducts.Count > 0)
            {
                product.MinPrice = organizationProducts.Min(p => p.Price);
                product.MaxPrice = organizationProducts.Max(p => p.Price);
                product.CountOffers = organizationProducts.Count();
            }
            else
            {
                product.MinPrice = 0;
                product.MaxPrice = 0;
                product.CountOffers = 0;
            }

            _dbContext.Products.Update(product);
            await _dbContext.SaveChangesAsync();
        }
    }
}
