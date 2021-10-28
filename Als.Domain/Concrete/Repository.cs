using Als.Domain.Abstract;
using Als.Domain.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Als.Domain.Concrete
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly AlsDbContext context;

        public Repository(AlsDbContext context)
            => this.context = context;

        public TEntity GetById<TId>(TId id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public async Task<TEntity> GetByIdAsync<TId>(TId id)
        {
            return await context.Set<TEntity>().FindAsync(id);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate)
        {
            IQueryable<TEntity> entities = context.Set<TEntity>();

            return entities.FirstOrDefault(predicate);
        }

        public virtual List<TEntity> GetRange(Expression<Func<TEntity, bool>> predicate)
        {
            IQueryable<TEntity> entities = context.Set<TEntity>();

            return entities.Where(predicate).ToList();
        }

        public void Add(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            context.Set<TEntity>().AddRange(entities);
        }

        public void Remove(TEntity entity)
        {
            context.Set<TEntity>().Remove(entity);
        }
    }
}