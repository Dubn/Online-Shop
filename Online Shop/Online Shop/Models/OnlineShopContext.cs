using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Online_Shop.Models
{
    public class OnlineShopContext : IdentityDbContext<ApplicationUser>
    {
        public OnlineShopContext(DbContextOptions<OnlineShopContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
    }
}
