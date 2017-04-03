using System;
using System.Collections.Generic;
using System.Text;

namespace Brambillator.Infrastructure.Tests.Repositories
{
    public static class EfSellUnitOfWorkDbInitializer
    {
        public static void Initialize(EfSellUnitOfWork context)
        {
            context.Database.EnsureCreated();
        }
    }
}
