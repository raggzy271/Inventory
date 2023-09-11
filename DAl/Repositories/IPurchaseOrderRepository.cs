using EAL;

namespace DAL.Repositories
{
    public interface IPurchaseOrderRepository
    {
        public void AddPurchaseOrder(PurchaseOrder purchaseOrder);

        public void UpdatePurchaseOrder(PurchaseOrder purchaseOrder);

        public void DeletePurchaseOrder(int id);

        public PurchaseOrder? GetPurchaseOrder(int id);

        public List<PurchaseOrder> GetAllPurchaseOrders();
    }
}