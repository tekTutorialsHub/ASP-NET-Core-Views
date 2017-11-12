using Microsoft.AspNetCore.Mvc;

namespace MVCCoreApp.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}