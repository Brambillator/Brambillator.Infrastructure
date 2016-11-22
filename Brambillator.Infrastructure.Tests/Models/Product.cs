using Brambillator.Infrastructure.Domain.Models;
using System;

namespace Brambillator.Infrastructure.Tests.Models
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public decimal CurrentValue { get; set; }
        public DateTime Registration { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
