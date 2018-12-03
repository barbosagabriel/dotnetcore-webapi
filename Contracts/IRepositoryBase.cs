using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Contracts
{
    public interface IRepositoryBase<T>
    {
        void Create(T entity);
        void Delete(T entity);
        IEnumerable<T> FindAll();
        IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression);
        IEnumerable<T> FindById(long id);
        void Save();
        void Update(T entity);
    }
}
