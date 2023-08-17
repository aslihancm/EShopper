using EShopper.Business.Abstract;
using EShopper.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace EShopper.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private IProductService _productService;
        public HomeController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {            
            return View(new ProductListModel
            {
                Products=_productService.GetAll().ToList()
            });
        }
    }
}
