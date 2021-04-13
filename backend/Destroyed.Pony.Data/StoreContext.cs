using Destroyed.Pony.Domain.Catalog;
using Destroyed.Pony.Domain.Orders;
using Microsoft.EntityFrameworkCore;

namespace Destroyed.Pony.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        { }

        public DbSet<Item> Items { get; set; }

        public DbSet<Order> Orders { get; set; }
    }
}
