using Microsoft.AspNetCore.Mvc;

namespace Bike.Controllers
{
    public class BrandsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult ShopByBrand(string Brand)
        {
            ViewData["brand"] = BrandsController;
            return ViewComponent():
                }


    }

}
