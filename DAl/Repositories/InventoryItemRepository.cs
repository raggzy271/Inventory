using EAL;
using Microsoft.EntityFrameworkCore;
using DAL.Data;

namespace DAL.Repositories
{
    public class InventoryItemRepository : IInventoryItemRepository
    {
        private readonly InventoryDbContext _inventoryDbContext;

        public InventoryItemRepository(InventoryDbContext inventoryDbContext)
        {
            _inventoryDbContext = inventoryDbContext;
        }

        public void AddItem(InventoryItem item)
        {
            _inventoryDbContext.inventoryItem.Add(item);
            _inventoryDbContext.SaveChanges();
        }

        public void UpdateItem(InventoryItem item)
        {
            _inventoryDbContext.Entry(item).State = EntityState.Modified;
            _inventoryDbContext.SaveChanges();
        }

        public void DeleteItem(int id)
        {
            var item = _inventoryDbContext.inventoryItem.Find(id);
            if (item != null)
            {
                _inventoryDbContext.inventoryItem.Remove(item);
                _inventoryDbContext.SaveChanges();
            }
        }

        public InventoryItem? GetItem(int id)
        {
            return _inventoryDbContext.inventoryItem.Find(id);
        }

        public List<InventoryItem> GetAllItems()
        {
            return _inventoryDbContext.inventoryItem.ToList();
        }
    }
}