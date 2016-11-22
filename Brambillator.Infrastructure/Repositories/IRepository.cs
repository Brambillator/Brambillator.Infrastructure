using Brambillator.Infrastructure.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Brambillator.Infrastructure.Domain.Repositories
{
    public interface IRepository<T> where T : Entity
    {
        IQueryable<T> AsQueryable();
        IEnumerable<T> All();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        T GetById(long id);

        void Add(T entity);
        void Remove(T entity);
        void Attach(T entity);
    }
}
