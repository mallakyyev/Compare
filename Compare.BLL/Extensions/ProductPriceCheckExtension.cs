using Compare.BLL.Services.Parser;
using Hangfire;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.Extensions
{
    public static class ProductPriceCheckExtension
    {
        public static void ProductPriceCheckWithInterval(this IApplicationBuilder builder, string interval)
        {
            RecurringJob.AddOrUpdate<IParser>((p) => p.ProductPriceCheckAsync(), interval);
        }
    }
}
