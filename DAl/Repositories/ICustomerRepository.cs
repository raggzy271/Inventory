using EAL;

namespace DAL.Repositories
{
    public interface ICustomerRepository
    {
        public void AddCustomer(Customer customer);

        public void UpdateCustomer(Customer customer);

        public void DeleteCustomer(int id);

        public Customer? GetCustomer(int id);

        public List<Customer> GetAllCustomers();
    }
}