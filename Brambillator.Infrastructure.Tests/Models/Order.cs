using Brambillator.Infrastructure.Domain.Models;
using System;

namespace Brambillator.Infrastructure.Tests.Models
{
    public class Order : Entity
    {
        public Customer Customer { get; set; }
        public Employee Seller { get; set; }
        public Product Item { get; set; }
        public decimal ChargedValue { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
