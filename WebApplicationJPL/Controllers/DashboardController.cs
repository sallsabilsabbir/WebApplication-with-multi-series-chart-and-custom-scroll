using Microsoft.AspNetCore.Mvc;

namespace WebApplicationJPL.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
