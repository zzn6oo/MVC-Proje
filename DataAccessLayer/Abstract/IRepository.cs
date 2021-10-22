﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
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
