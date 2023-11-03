using Microsoft.EntityFrameworkCore;

namespace Rent_Property.Models
{
    public class RentContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Listing> Listings { get; set; }
        public RentContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
