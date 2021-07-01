using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.Services.Checking
{
    public interface ICheckingService
    {
        //Task CheckMinMaxPriceProducts();

        Task CheckMinMaxPriceProductById(int productId);
    }
}
