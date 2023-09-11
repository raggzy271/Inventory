using EAL;
using Microsoft.EntityFrameworkCore;
using DAL.Data;

namespace DAL.Repositories
{
    public class PurchaseOrderLineItemRepository : IPurchaseOrderLineItemRepository
    {
        private readonly InventoryDbContext _inventoryDbContext;

        public PurchaseOrderLineItemRepository(InventoryDbContext inventoryDbContext)
        {
            _inventoryDbContext = inventoryDbContext;
        }

        public void AddPurchaseOrderLineItem(PurchaseOrderLineItem purchaseOrderLineItem)
        {
            _inventoryDbContext.PurchaseOrderLineItem.Add(purchaseOrderLineItem);
            _inventoryDbContext.SaveChanges();
        }

        public void UpdatePurchaseOrderLineItem(PurchaseOrderLineItem purchaseOrderLineItem)
        {
            _inventoryDbContext.Entry(purchaseOrderLineItem).State = EntityState.Modified;
            _inventoryDbContext.SaveChanges();
        }

        public void DeletePurchaseOrderLineItem(int id)
        {
            var purchaseOrderLineItem = _inventoryDbContext.PurchaseOrderLineItem.Find(id);
            if (purchaseOrderLineItem != null)
            {
                _inventoryDbContext.PurchaseOrderLineItem.Remove(purchaseOrderLineItem);
                _inventoryDbContext.SaveChanges();
            }
        }

        public PurchaseOrderLineItem? GetPurchaseOrderLineItem(int id)
        {
            return _inventoryDbContext.PurchaseOrderLineItem.Find(id);
        }

        public List<PurchaseOrderLineItem> GetAllPurchaseOrderLineItems()
        {
            return _inventoryDbContext.PurchaseOrderLineItem.ToList();
        }
    }
}