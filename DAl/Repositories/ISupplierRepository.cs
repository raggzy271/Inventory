using EAL;

namespace DAL.Repositories
{
    public interface ISupplierRepository
    {
        public void AddSupplier(Supplier supplier);

        public void UpdateSupplier(Supplier supplier);

        public void DeleteSupplier(int id);

        public Supplier? GetSupplier(int id);

        public List<Supplier> GetAllSuppliers();
    }
}