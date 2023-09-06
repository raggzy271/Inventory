using EAL;
using Microsoft.EntityFrameworkCore;
using DAL.Data;

namespace DAL.Repositories
{
    public class WarehouseRepository : IWarehouseRepository
    {
        private readonly InventoryDbContext _inventoryDbContext;

        public WarehouseRepository(InventoryDbContext inventoryDbContext)
        {
            _inventoryDbContext = inventoryDbContext;
        }

        public void AddWarehouse(Warehouse warehouse)
        {
            _inventoryDbContext.warehouse.Add(warehouse);
            _inventoryDbContext.SaveChanges();
        }

        public void UpdateWarehouse(Warehouse warehouse)
        {
            _inventoryDbContext.Entry(warehouse).State = EntityState.Modified;
            _inventoryDbContext.SaveChanges();
        }

        public void DeleteWarehouse(int id)
        {
            var warehouse = _inventoryDbContext.warehouse.Find(id);
            if (warehouse != null)
            {
                _inventoryDbContext.warehouse.Remove(warehouse);
                _inventoryDbContext.SaveChanges();
            }
        }

        public Warehouse? GetWarehouse(int id)
        {
            return _inventoryDbContext.warehouse.Find(id);
        }

        public List<Warehouse> GetAllWarehouses()
        {
            return _inventoryDbContext.warehouse.ToList();
        }
    }
}