using Compare.BLL.Services.Parser;
using Compare.DAL.Data;
using Compare.DAL.Models.OnlineMarkets;
using Hangfire;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.Extensions
{
    public static class YuzharytProductPriceParserExtension
    {
        public static void YuzharytProductPriceParserWithInterval(this IApplicationBuilder builder, string interval)
        {
            RecurringJob.AddOrUpdate<IParser>((p) => p.ParserYuzharytProductPriceAsync(), interval);
        }
    }
}
