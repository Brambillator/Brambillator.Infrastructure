using Brambillator.Infrastructure.Domain.Models;
using System;

namespace Brambillator.Infrastructure.Tests.Models
{
    public class Employee : Entity
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public DateTime EmploymentDate { get; set; }
    }
}
