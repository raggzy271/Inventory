using EAL;

namespace DAL.Repositories
{
    public interface IInventoryTransactionRepository
    {
        public void AddTransaction(InventoryTransaction transaction);

        public void UpdateTransaction(InventoryTransaction transaction);

        public void DeleteTransaction(int id);

        public InventoryTransaction? GetTransaction(int id);

        public List<InventoryTransaction> GetAllTransactions();
    }
}