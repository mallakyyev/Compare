using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.Services.Parser
{
    public interface IParser
    {
        Task ProductPriceCheckAsync();

        Task ParserYuzharytProductPriceAsync();

        Task ParserOrganizationProductPriceAsync();

        //Task ParserYuzharytProductAsync();
    }
}
