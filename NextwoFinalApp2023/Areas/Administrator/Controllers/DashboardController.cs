using Microsoft.AspNetCore.Mvc;

namespace NextwoFinalApp2023.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
