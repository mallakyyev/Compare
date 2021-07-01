using AutoMapper;
using Compare.BLL.DTOs.Product;
using Compare.BLL.Services.Catalog;
using Compare.BLL.Services.Language;
using Compare.BLL.Services.Manufacture;
using Compare.BLL.Services.Product;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compare.Areas.Administrator.Controllers.Product
{
    [Area("Administrator")]
    [Authorize(Roles = "Admin, Directory management")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ILanguageService _languageService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, ILanguageService languageService, IMapper mapper)
        {
            _productService = productService;
            _languageService = languageService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Languages = _languageService.GetAllPublishLanguage();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductDTO value)
        {
            if (ModelState.IsValid)
            {
                await _productService.CreateProductAsync(value);
                return RedirectToAction("Index");
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage();
            return View(value);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var editProductDTO = await _productService.GetProductAsync(id);

            ViewBag.Languages = _languageService.GetAllPublishLanguage();

            return View(editProductDTO);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditProductDTO value)
        {
            if (ModelState.IsValid)
            {
                await _productService.EditProductAsync(value);
                return RedirectToAction("Index");
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage();

            return View(value);
        }

        [HttpGet]
        public async Task<IActionResult> CopyProduct(int id)
        {
            var editProductDTO = await _productService.GetProductAsync(id);
            var copyProduct = _mapper.Map<CreateProductDTO>(editProductDTO);
            copyProduct.ProductIdAttribute = id;

            ViewBag.Languages = _languageService.GetAllPublishLanguage();

            return View(copyProduct);
        }

        [HttpPost]
        public async Task<IActionResult> CopyProduct(CreateProductDTO value)
        {
            if (ModelState.IsValid)
            {
                await _productService.CreateCopyProductAsync(value);
                return RedirectToAction("Index");
            }
            ViewBag.Languages = _languageService.GetAllPublishLanguage();

            return View(value);
        }
    }
}
