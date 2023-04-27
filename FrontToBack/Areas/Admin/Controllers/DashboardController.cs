using FrontToBack.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace FirstAdminPanel.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {

        public IActionResult Index()
        {      
            return View();
        }
    }
}
