using EAL;

namespace DAL.Repositories
{
    public interface IProductRepository
    {
        public void AddProduct(Product product);

        public void UpdateProduct(Product product);

        public void DeleteProduct(int id);

        public Product? GetProduct(int id);

        public List<Product> GetAllProducts();
    }
}