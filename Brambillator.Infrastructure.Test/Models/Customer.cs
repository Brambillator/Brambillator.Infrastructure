using Brambillator.Infrastructure.Domain.Models;
using System;

namespace Brambillator.Infrastructure.Tests.Models
{
    public class Customer : Entity
    {
        public string Name { get; set; }
        public DateTime MemberSince { get; set; }
    }
}
