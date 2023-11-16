using Microsoft.EntityFrameworkCore;
using Wanna_Buyl.Models.Domain;

namespace Wanna_Buyl.Data
{
    public class WannaBuyContext : DbContext
    {
        public WannaBuyContext(DbContextOptions options)
        :base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Filter> Filters { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
    }
}
