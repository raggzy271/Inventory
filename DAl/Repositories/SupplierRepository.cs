using EAL;
using Microsoft.EntityFrameworkCore;
using DAL.Data;

namespace DAL.Repositories
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly InventoryDbContext _inventoryDbContext;

        public SupplierRepository(InventoryDbContext inventoryDbContext)
        {
            _inventoryDbContext = inventoryDbContext;
        }

        public void AddSupplier(Supplier supplier)
        {
            _inventoryDbContext.Supplier.Add(supplier);
            _inventoryDbContext.SaveChanges();
        }

        public void UpdateSupplier(Supplier supplier)
        {
            _inventoryDbContext.Entry(supplier).State = EntityState.Modified;
            _inventoryDbContext.SaveChanges();
        }

        public void DeleteSupplier(int id)
        {
            var supplier = _inventoryDbContext.Supplier.Find(id);
            if (supplier != null)
            {
                _inventoryDbContext.Supplier.Remove(supplier);
                _inventoryDbContext.SaveChanges();
            }
        }

        public Supplier? GetSupplier(int id)
        {
            return _inventoryDbContext.Supplier.Find(id);
        }

        public List<Supplier> GetAllSuppliers()
        {
            return _inventoryDbContext.Supplier.ToList();
        }
    }
}