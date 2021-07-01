using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compare.Areas.Administrator.Controllers.Manufacture
{
    [Area("Administrator")]
    [Authorize(Roles = "Admin, Directory management")]
    public class ManufactureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
