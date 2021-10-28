using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Als.Domain.Abstract
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity GetById<TId>(TId id);
        Task<TEntity> GetByIdAsync<TId>(TId id);

        TEntity Get(Expression<Func<TEntity, bool>> predicate);

        List<TEntity> GetRange(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);

        void AddRange(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);
    }
}
