using EAL;

namespace DAL.Repositories
{
    public interface IInventoryItemRepository
    {
        public void AddItem(InventoryItem item);

        public void UpdateItem(InventoryItem item);

        public void DeleteItem(int id);

        public InventoryItem? GetItem(int id);

        public List<InventoryItem> GetAllItems();
    }
}