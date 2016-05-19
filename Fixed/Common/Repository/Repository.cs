using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Fixed.Common.Entity;

namespace Fixed.Common.Repository
{
    public abstract class Repository<TEntity, TContext> : IRepository<TEntity>
        where TContext : DbContext 
        where TEntity : class
    {
        protected TContext Context;
        private bool _disposed = false;

        public Repository(TContext context)
        {
            Context = context;
        }

        public TEntity Find(Guid id)
        {
            return GetEntityDbSet().Find(id);
        }

        public IEnumerable<TEntity> FindAll(int offset, int limit)
        {
            return GetEntityDbSet()
                .Skip(offset)
                .Take(limit)
                .ToList()
            ;
        }

        public void Insert(TEntity entity)
        {
            GetEntityDbSet().Add(entity);
        }

        public void Update(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(TEntity entity)
        {
            GetEntityDbSet().Remove(entity);
        }

        public void Save()
        {
            Context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    Context.Dispose();
                }
            }

            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public abstract DbSet<TEntity> GetEntityDbSet();
    }
}
