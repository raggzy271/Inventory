using EAL;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DAL.Data
{
    public class InventoryDbContext : DbContext
    {
        public InventoryDbContext(DbContextOptions<InventoryDbContext> options) : base(options) {}

        public DbSet<Customer> Customer { get; set; }
        
        public DbSet<Product> Product { get; set; }
        
        public DbSet<PurchaseOrder> PurchaseOrder { get; set; }
        
        public DbSet<PurchaseOrderLineItem> PurchaseOrderLineItem { get; set; }

        public DbSet<SalesOrder> SalesOrder { get; set; }

        public DbSet<SalesOrderLineItem> SalesOrderLineItem { get; set; }

        public DbSet<Supplier> Supplier { get; set; }        
    }
}
