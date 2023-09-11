using EAL;

namespace DAL.Repositories
{
    public interface IPurchaseOrderLineItemRepository
    {
        public void AddPurchaseOrderLineItem(PurchaseOrderLineItem purchaseOrderLineItem);

        public void UpdatePurchaseOrderLineItem(PurchaseOrderLineItem purchaseOrderLineItem);

        public void DeletePurchaseOrderLineItem(int id);

        public PurchaseOrderLineItem? GetPurchaseOrderLineItem(int id);

        public List<PurchaseOrderLineItem> GetAllPurchaseOrderLineItems();
    }
}