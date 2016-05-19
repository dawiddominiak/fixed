using System;
using System.Collections.Generic;
using Fixed.Common.Entity;

namespace Fixed.Common.Service
{
    public class RepositoryService<TEntity, TRepository> : IRepositoryService<TEntity>
        where TEntity : class
        where TRepository : IRepository<TEntity>
    {
        protected TRepository Repository;
        // ReSharper disable once RedundantDefaultMemberInitializer
        private bool _disposed = false;

        public RepositoryService(TRepository repository)
        {
            Repository = repository;
        } 

        public IEnumerable<TEntity> FindAll(int offset, int limit)
        {
            return Repository.FindAll(offset, limit);
        }

        public TEntity Find(Guid id)
        {
            return Repository.Find(id);
        }

        public void Insert(TEntity entity)
        {
            Repository.Insert(entity);
        }

        public void Update(TEntity entity)
        {
            Repository.Update(entity);
        }

        public void Delete(TEntity entity)
        {
            Repository.Delete(entity);
        }

        public void Save()
        {
            Repository.Save();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    Repository.Dispose();
                }
            }

            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
