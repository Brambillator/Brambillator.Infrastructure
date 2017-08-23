using Brambillator.Infrastructure.Domain.Repositories;
using Brambillator.Infrastructure.Tests.Models;

namespace Brambillator.Infrastructure.Tests.Repositories
{
    public class MemorySellUnitOfWork : ISellUnitOfWork
    {
        private MemoryRepository<Customer> customerRepository;
        private MemoryRepository<Employee> employeeRepository;
        private MemoryRepository<Order> orderRepository;
        private MemoryRepository<Product> productRepository;

        public MemorySellUnitOfWork()
        {
            customerRepository = new MemoryRepository<Customer>();
            employeeRepository = new MemoryRepository<Employee>();
            orderRepository = new MemoryRepository<Order>();
            productRepository = new MemoryRepository<Product>();
        }

        public IRepository<Order> OrderRepository { get { return orderRepository; } }

        public IRepository<Customer> CustomerRepository { get { return customerRepository; } }

        public IRepository<Employee> EmployeeRepository { get { return employeeRepository; } }

        public IRepository<Product> ProductRepository { get { return productRepository; } }

        public void Commit()
        {
            
        }
    }
}
