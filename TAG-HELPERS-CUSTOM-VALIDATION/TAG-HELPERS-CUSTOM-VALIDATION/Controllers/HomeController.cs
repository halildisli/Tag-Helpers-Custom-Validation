using TAG_HELPERS_CUSTOM_VALIDATION.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace TAG_HELPERS_CUSTOM_VALIDATION.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult CustomerDetails()
        {
            //Customer sınıfı oluşturunuz
            //customerID,CompanyName,Age,Email,JoinDate,Enum CustomerType=> New=0, Regular ,Elite
            //Required , ERROR MESSAGE

            //html tag helper ? asp tag helper nedir ?

            ViewBag.postback = "Hayallerim";
            return View(new Customer());
        }

        [HttpPost] //DERSTE BUNU YAZMAYI UNUTTUM.
        public IActionResult CustomerDetails(Customer customer)
        {
            //Customer sınıfı oluşturunuz
            //customerID,CompanyName,Age,Email,JoinDate,Enum CustomerType=> New=0, Regular ,Elite
            //Required , ERROR MESSAGE

            //html tag helper ? asp tag helper nedir ?

      
            return View(customer);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}