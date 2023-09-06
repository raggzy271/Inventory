using EAL;
using Microsoft.EntityFrameworkCore;

namespace DAL.Data
{
    public class InventoryDbContext : DbContext
    {
        public InventoryDbContext(DbContextOptions<InventoryDbContext> options) : base(options) {}

        public DbSet<InventoryItem> inventoryItem { get; set; }

        public DbSet<InventoryTransaction> inventoryTransaction { get; set; }

        public DbSet<Location> location { get; set; }

        public DbSet<Warehouse> warehouse { get; set; }
    }
}
