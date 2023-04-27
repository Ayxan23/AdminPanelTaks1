using FrontToBack.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace FirstAdminPanel.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _context;

        public SliderController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.ToList();
            return View(sliders);
        }

        [HttpPost]
        public IActionResult Create(Slider slider)
        {
            _context.Sliders.Add(slider);
            _context.SaveChanges();

            return View();
        }
    }
}
