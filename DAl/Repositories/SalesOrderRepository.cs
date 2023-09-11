using EAL;
using Microsoft.EntityFrameworkCore;
using DAL.Data;

namespace DAL.Repositories
{
    public class SalesOrderRepository : ISalesOrderRepository
    {
        private readonly InventoryDbContext _inventoryDbContext;

        public SalesOrderRepository(InventoryDbContext inventoryDbContext)
        {
            _inventoryDbContext = inventoryDbContext;
        }

        public void AddSalesOrder(SalesOrder salesOrder)
        {
            _inventoryDbContext.SalesOrder.Add(salesOrder);
            _inventoryDbContext.SaveChanges();
        }

        public void UpdateSalesOrder(SalesOrder salesOrder)
        {
            _inventoryDbContext.Entry(salesOrder).State = EntityState.Modified;
            _inventoryDbContext.SaveChanges();
        }

        public void DeleteSalesOrder(int id)
        {
            var salesOrder = _inventoryDbContext.SalesOrder.Find(id);
            if (salesOrder != null)
            {
                _inventoryDbContext.SalesOrder.Remove(salesOrder);
                _inventoryDbContext.SaveChanges();
            }
        }

        public SalesOrder? GetSalesOrder(int id)
        {
            return _inventoryDbContext.SalesOrder.Find(id);
        }

        public List<SalesOrder> GetAllSalesOrders()
        {
            return _inventoryDbContext.SalesOrder.ToList();
        }
    }
}