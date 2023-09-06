using EAL;

namespace DAL.Repositories
{
    public interface IWarehouseRepository
    {
        public void AddWarehouse(Warehouse warehouse);

        public void UpdateWarehouse(Warehouse warehouse);

        public void DeleteWarehouse(int id);

        public Warehouse? GetWarehouse(int id);

        public List<Warehouse> GetAllWarehouses();
    }
}