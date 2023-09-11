using EAL;
using Microsoft.EntityFrameworkCore;
using DAL.Data;

namespace DAL.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly InventoryDbContext _inventoryDbContext;

        public CustomerRepository(InventoryDbContext inventoryDbContext)
        {
            _inventoryDbContext = inventoryDbContext;
        }

        public void AddCustomer(Customer customer)
        {
            _inventoryDbContext.Customer.Add(customer);
            _inventoryDbContext.SaveChanges();
        }

        public void UpdateCustomer(Customer customer)
        {
            _inventoryDbContext.Entry(customer).State = EntityState.Modified;
            _inventoryDbContext.SaveChanges();
        }

        public void DeleteCustomer(int id)
        {
            var customer = _inventoryDbContext.Customer.Find(id);
            if (customer != null)
            {
                _inventoryDbContext.Customer.Remove(customer);
                _inventoryDbContext.SaveChanges();
            }
        }

        public Customer? GetCustomer(int id)
        {
            return _inventoryDbContext.Customer.Find(id);
        }

        public List<Customer> GetAllCustomers()
        {
            return _inventoryDbContext.Customer.ToList();
        }
    }
}