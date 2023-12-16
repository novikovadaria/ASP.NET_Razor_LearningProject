using Microsoft.EntityFrameworkCore;
using TheNekoPizzaria.Models;

namespace TheNekoPizzaria.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<PizzaOrder> PizzaOrders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
    }
}
