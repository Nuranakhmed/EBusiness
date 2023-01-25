using Microsoft.AspNetCore.Mvc;

namespace EBusiness.Areas.admin.Controllers
{
    [Area("admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
