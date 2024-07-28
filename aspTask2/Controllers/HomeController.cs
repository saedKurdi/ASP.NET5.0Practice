using Microsoft.AspNetCore.Mvc;
namespace aspTask2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
