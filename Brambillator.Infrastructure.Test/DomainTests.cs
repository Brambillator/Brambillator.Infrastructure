using Brambillator.Infrastructure.Tests.Repositories;
using System;
using Xunit;

namespace Brambillator.Infrastructure.Tests
{
    public class DomainTests
    {
        public DomainTests()
        {
            EfSellUnitOfWorkDbInitializer.Initialize(new EfSellUnitOfWork());
        }

        [Fact]
        public void DomainTests_EntityFramework()
        {

            ISellUnitOfWork unitOfWork;

            // Simulates an injection of EfSellUnitOfWork for use with entity framework
            unitOfWork = new EfSellUnitOfWork();
            //unitOfWork = new MemorySellUnitOfWork();

            // Create Data
            Models.Product apple = new Models.Product() { Name = "Apple", Registration = DateTime.Now, CurrentValue = 0.5M };
            Models.Product orange = new Models.Product() { Name = "Orange", Registration = DateTime.Now, CurrentValue = 0.4M };
            Models.Product watermelon = new Models.Product() { Name = "Watermelon", Registration = DateTime.Now, CurrentValue = 1.2M };
            
            Models.Employee employeeJohn = new Models.Employee() { Name = "John", EmploymentDate = new DateTime(2016, 11, 22), Salary = 3500.0M };
            Models.Employee employeeAdam = new Models.Employee() { Name = "Adam", EmploymentDate = new DateTime(2016, 11, 22), Salary = 2200.0M };
            
            Models.Customer customerMary = new Models.Customer() { Name = "Mary", MemberSince = new DateTime(2016, 11, 23) };
            Models.Customer customerGeorge = new Models.Customer() { Name = "George", MemberSince = new DateTime(2016, 11, 23) };
            
            unitOfWork.ProductRepository.Add(apple);
            unitOfWork.ProductRepository.Add(orange);
            unitOfWork.ProductRepository.Add(watermelon);
            
            unitOfWork.EmployeeRepository.Add(employeeJohn);
            unitOfWork.EmployeeRepository.Add(employeeAdam);
            
            unitOfWork.CustomerRepository.Add(customerMary);
            unitOfWork.CustomerRepository.Add(customerGeorge);
            
            unitOfWork.Commit();

            Assert.True(true);
            //Models.Order newSellOrder = new Models.Order() {  };
        }
    }
}
