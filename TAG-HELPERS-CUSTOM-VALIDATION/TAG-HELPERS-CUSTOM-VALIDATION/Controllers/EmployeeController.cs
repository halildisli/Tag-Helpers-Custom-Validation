using TAG_HELPERS_CUSTOM_VALIDATION.Models;
using Microsoft.AspNetCore.Mvc;

namespace TAG_HELPERS_CUSTOM_VALIDATION.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View(new Employee());
        }
        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            return View(employee);
        }
    }
}
