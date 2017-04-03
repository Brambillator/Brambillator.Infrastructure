namespace Brambillator.Infrastructure.Domain.Models
{
    public abstract class Entity
    {
        public long Id { get; set; }
        public EntityState State { get; set; }
    }
}
