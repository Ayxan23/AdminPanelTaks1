using FirstAdminPanel.Models;
using FirstAdminPanel.ViewModels;
using FrontToBack.Contexts;
using FrontToBack.Models;
using Microsoft.AspNetCore.Mvc;

namespace FrontToBack.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        List<Info> infos = _context.Infos.ToList();
        List<Slider> sliders = _context.Sliders.ToList();

        HomeViewModel homeViewModel= new()
        {
            Sliders = sliders,
            Infos= infos    
        };

        return View(homeViewModel);
    }
}
