using FirstAdminPanel.Models;
using FrontToBack.Models;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack.Contexts
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Info> Infos { get; set; } = null!;

        public DbSet<Slider> Sliders { get; set; } = null!;

    }
}
