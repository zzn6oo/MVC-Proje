using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        void Delete(T param);
        void Insert(T param);
        List<T> List();
        void Update(T param);

        List<T> List(Expression<Func<T, bool>> filter);
    }
}
