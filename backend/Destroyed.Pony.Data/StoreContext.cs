using Destroyed.Pony.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Destroyed.Pony.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
            {}
        public DbSet<Item> Items { get; set; }
    }
}
