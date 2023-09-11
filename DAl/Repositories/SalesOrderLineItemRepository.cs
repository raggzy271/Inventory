using EAL;
using Microsoft.EntityFrameworkCore;
using DAL.Data;

namespace DAL.Repositories
{
    public class SalesOrderLineItemRepository : ISalesOrderLineItemRepository
    {
        private readonly InventoryDbContext _inventoryDbContext;

        public SalesOrderLineItemRepository(InventoryDbContext inventoryDbContext)
        {
            _inventoryDbContext = inventoryDbContext;
        }

        public void AddSalesOrderLineItem(SalesOrderLineItem salesOrderLineItem)
        {
            _inventoryDbContext.SalesOrderLineItem.Add(salesOrderLineItem);
            _inventoryDbContext.SaveChanges();
        }

        public void UpdateSalesOrderLineItem(SalesOrderLineItem salesOrderLineItem)
        {
            _inventoryDbContext.Entry(salesOrderLineItem).State = EntityState.Modified;
            _inventoryDbContext.SaveChanges();
        }

        public void DeleteSalesOrderLineItem(int id)
        {
            var salesOrderLineItem = _inventoryDbContext.SalesOrderLineItem.Find(id);
            if (salesOrderLineItem != null)
            {
                _inventoryDbContext.SalesOrderLineItem.Remove(salesOrderLineItem);
                _inventoryDbContext.SaveChanges();
            }
        }

        public SalesOrderLineItem? GetSalesOrderLineItem(int id)
        {
            return _inventoryDbContext.SalesOrderLineItem.Find(id);
        }

        public List<SalesOrderLineItem> GetAllSalesOrderLineItems()
        {
            return _inventoryDbContext.SalesOrderLineItem.ToList();
        }
    }
}