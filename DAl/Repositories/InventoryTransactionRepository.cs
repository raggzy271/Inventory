using EAL;
using Microsoft.EntityFrameworkCore;
using DAL.Data;

namespace DAL.Repositories
{
    public class InventoryTransactionRepository : IInventoryTransactionRepository
    {
        private readonly InventoryDbContext _inventoryDbContext;

        public InventoryTransactionRepository(InventoryDbContext inventoryDbContext)
        {
            _inventoryDbContext = inventoryDbContext;
        }

        public void AddTransaction(InventoryTransaction transaction)
        {
            _inventoryDbContext.inventoryTransaction.Add(transaction);
            _inventoryDbContext.SaveChanges();
        }

        public void UpdateTransaction(InventoryTransaction transaction)
        {
            _inventoryDbContext.Entry(transaction).State = EntityState.Modified;
            _inventoryDbContext.SaveChanges();
        }

        public void DeleteTransaction(int id)
        {
            var transaction = _inventoryDbContext.inventoryTransaction.Find(id);
            if (transaction != null)
            {
                _inventoryDbContext.inventoryTransaction.Remove(transaction);
                _inventoryDbContext.SaveChanges();
            }
        }

        public InventoryTransaction? GetTransaction(int id)
        {
            return _inventoryDbContext.inventoryTransaction.Find(id);
        }

        public List<InventoryTransaction> GetAllTransactions()
        {
            return _inventoryDbContext.inventoryTransaction.ToList();
        }
    }
}