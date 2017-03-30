using Brambillator.Infrastructure.Domain.Repositories;
using Brambillator.Infrastructure.Tests.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brambillator.Infrastructure.Tests.Repositories
{
    /// <summary>
    /// Interface that represents a sell action of a product to a customer by a employee.
    /// </summary>
    public interface ISellUnitOfWork
    {
        IRepository<Order> OrderRepository { get; }
        IRepository<Customer> CustomerRepository { get; }
        IRepository<Employee> EmployeeRepository { get; }
        IRepository<Product> ProductRepository { get; }

        void Commit();
    }
}
