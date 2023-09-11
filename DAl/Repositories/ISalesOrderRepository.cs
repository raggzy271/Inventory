using EAL;

namespace DAL.Repositories
{
    public interface ISalesOrderRepository
    {
        public void AddSalesOrder(SalesOrder salesOrder);

        public void UpdateSalesOrder(SalesOrder salesOrder);

        public void DeleteSalesOrder(int id);

        public SalesOrder? GetSalesOrder(int id);

        public List<SalesOrder> GetAllSalesOrders();
    }
}