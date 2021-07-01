using Compare.BLL.Services.Info;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compare.Components
{
    public class FooterInformationViewComponent : ViewComponent
    {
        private readonly IInformationService _informationService;

        public FooterInformationViewComponent(IInformationService informationService)
        {
            _informationService = informationService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var information = await _informationService.GetInformationListAsync(DAL.Models.Enums.InformationStatus.FooterInfo);
            return View(information);
        }
    }
}
