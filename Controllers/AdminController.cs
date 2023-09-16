using Microsoft.AspNetCore.Mvc;
using WebApplication2.Data.Repositories.Interfaces;
using WebApplication2.Services.Interfaces;
using WebApplication2.Services;
using WebApplication2.ViewModels.Products;

namespace WebApplication2.Controllers
{
    public class AdminController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IVendorService _vendorService;
        public AdminController(
            IProductService productService,
            ICategoryService categoryService,
            IVendorService vendorService)
        {
            _productService = productService;
            _categoryService = categoryService;
            _vendorService = vendorService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddEdit(int? id)
        {
            ViewBag.Category = _categoryService.GetListForDropdown();
            ViewBag.Vendor = _vendorService.GetListForDropdown();
            ProductAddEditViewModel model = id.HasValue ?
                _productService.GetById(id.Value) :
                new ProductAddEditViewModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult AddEdit(ProductAddEditViewModel model)
        {
            ViewBag.Category = _categoryService.GetListForDropdown();
            ViewBag.Vendor = _vendorService.GetListForDropdown();
            if (model.Id > 0)
            {
                _productService.Update(model);
            }
            else
            {
                _productService.Add(model);
            }
            return View();
        }
    }
}
