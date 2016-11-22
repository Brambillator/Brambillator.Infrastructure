using Brambillator.Infrastructure.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Brambillator.Infrastructure.Domain.Repositories
{
    public class EfRepository<T> : IRepository<T> where T : Entity
    {
        private readonly DbSet<T> _dbSet;

        public EfRepository(DbSet<T> dbSet)
        {
            _dbSet = dbSet;
        }

        #region IRepository<T> implementation

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public IEnumerable<T> All()
        {
            return _dbSet;
        }

        public IQueryable<T> AsQueryable()
        {
            return _dbSet.AsQueryable<T>();
        }

        public void Attach(T entity)
        {
            _dbSet.Attach(entity);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }

        public T GetById(long id)
        {
            return _dbSet.Find(id);
        }

        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }

        #endregion
    }
}
