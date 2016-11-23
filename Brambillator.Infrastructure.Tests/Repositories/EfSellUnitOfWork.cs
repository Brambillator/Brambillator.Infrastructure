using System;
using System.Collections.Generic;
using System.Text;
using Brambillator.Infrastructure.Domain.Repositories;
using Brambillator.Infrastructure.Tests.Models;
using Microsoft.EntityFrameworkCore;

namespace Brambillator.Infrastructure.Tests.Repositories
{
    public class EfSellUnitOfWork : DbContext, ISellUnitOfWork
    {
        private readonly EfRepository<Customer> customerRepository;
        private readonly EfRepository<Employee> employeeRepository;
        private readonly EfRepository<Order> orderRepository;
        private readonly EfRepository<Product> productRepository;

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }

        public EfSellUnitOfWork()
        {
            customerRepository = new EfRepository<Customer>(Customers);
            employeeRepository = new EfRepository<Employee>(Employees);
            orderRepository = new EfRepository<Order>(Orders);
            productRepository = new EfRepository<Product>(Products);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=InfrastructureTest;Trusted_Connection=True;");
        }

        public IRepository<Customer> CustomerRepository
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IRepository<Employee> EmployeeRepository
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IRepository<Order> OrderRepository
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IRepository<Product> ProductRepository
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }
    }
}
