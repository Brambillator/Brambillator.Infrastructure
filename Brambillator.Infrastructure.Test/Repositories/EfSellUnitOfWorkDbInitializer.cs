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
