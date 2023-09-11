using EAL;
using Microsoft.EntityFrameworkCore;
using DAL.Data;

namespace DAL.Repositories
{
    public class PurchaseOrderRepository : IPurchaseOrderRepository
    {
        private readonly InventoryDbContext _inventoryDbContext;

        public PurchaseOrderRepository(InventoryDbContext inventoryDbContext)
        {
            _inventoryDbContext = inventoryDbContext;
        }

        public void AddPurchaseOrder(PurchaseOrder purchaseOrder)
        {
            _inventoryDbContext.PurchaseOrder.Add(purchaseOrder);
            _inventoryDbContext.SaveChanges();
        }

        public void UpdatePurchaseOrder(PurchaseOrder purchaseOrder)
        {
            _inventoryDbContext.Entry(purchaseOrder).State = EntityState.Modified;
            _inventoryDbContext.SaveChanges();
        }

        public void DeletePurchaseOrder(int id)
        {
            var purchaseOrder = _inventoryDbContext.PurchaseOrder.Find(id);
            if (purchaseOrder != null)
            {
                _inventoryDbContext.PurchaseOrder.Remove(purchaseOrder);
                _inventoryDbContext.SaveChanges();
            }
        }

        public PurchaseOrder? GetPurchaseOrder(int id)
        {
            return _inventoryDbContext.PurchaseOrder.Find(id);
        }

        public List<PurchaseOrder> GetAllPurchaseOrders()
        {
            return _inventoryDbContext.PurchaseOrder.ToList();
        }
    }
}