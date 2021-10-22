using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccessLayer.Concrete.Repositories
{
    public interface IRepository<T>
    {
        List<T> List();
        void Insert(T param);
        T Get(Expression<Func<T, bool>> filter);
        void Delete(T param);
        void Update(T param);
        List<T> List(Expression<Func<T, bool>> filter);
    }
}