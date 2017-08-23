using Brambillator.Infrastructure.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Brambillator.Infrastructure.Domain.Repositories
{
    public class MemoryRepository<T> : IRepository<T> where T : Entity
    {
        List<T> memory = new List<T>();

        public void Add(T entity)
        {
            entity.State = EntityState.Added;
            memory.Add(entity);
        }

        public IEnumerable<T> All()
        {
            return memory;
        }

        public IQueryable<T> AsQueryable()
        {
            return memory.AsQueryable<T>();
        }

        public void Attach(T entity)
        {
            if (!memory.Exists(e => e.Id == entity.Id))
            {
                memory.Add(entity);
                entity.State = EntityState.Added;
            }
            else
                entity.State = EntityState.Modified;
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return memory.AsQueryable().Where(predicate);
        }

        public T GetById(long id)
        {
            return memory.Find(t => t.Id == id);
        }

        public void Remove(T entity)
        {
            if (entity.State == EntityState.Added || entity.State == EntityState.Modified)
                memory.Remove(entity);
            else
                entity.State = EntityState.Deleted;
        }
    }
}
