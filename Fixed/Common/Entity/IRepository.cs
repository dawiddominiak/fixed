using System;
using System.Collections.Generic;

namespace Fixed.Common.Entity
{
    public interface IRepository<TEntity> : IDisposable
    {
        IEnumerable<TEntity> FindAll(int offset, int limit);
        TEntity Find(Guid id);
        void Insert(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        void Save();
    }
}
