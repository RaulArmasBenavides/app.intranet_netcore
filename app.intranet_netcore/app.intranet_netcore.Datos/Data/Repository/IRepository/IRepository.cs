﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace app.intranet_netcore.Datos.Data.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);

        IEnumerable<T> GetAll(
             Expression<Func<T, bool>> filter = null,
             Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                string includeProperties = null
        );

        void Add(T entity);
        void Remove(int id);
        void Remove(T entity);
        T Find(T o);
        T FindById(int o);
        List<T> ReadAll(int skip = 0, int limit = 30);


    }
}
