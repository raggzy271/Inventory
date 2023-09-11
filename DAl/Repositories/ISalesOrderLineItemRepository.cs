using EAL;

namespace DAL.Repositories
{
    public interface ISalesOrderLineItemRepository
    {
        public void AddSalesOrderLineItem(SalesOrderLineItem salesOrderLineItem);

        public void UpdateSalesOrderLineItem(SalesOrderLineItem salesOrderLineItem);

        public void DeleteSalesOrderLineItem(int id);

        public SalesOrderLineItem? GetSalesOrderLineItem(int id);

        public List<SalesOrderLineItem> GetAllSalesOrderLineItems();
    }
}