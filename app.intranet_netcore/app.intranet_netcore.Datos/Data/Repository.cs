using app.intranet_netcore.Datos.Data.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace app.intranet_netcore.Datos.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {

        protected readonly  DbContext _context;
        internal DbSet<T> _dbset;

        public Repository(DbContext context)
        {
            _context = context;
            this._dbset = context.Set<T>();
        }

        public void Add(T entity)
        {
            _dbset.Add(entity);
        }

        public T Find(T o)
        {
            throw new NotImplementedException();
        }

        public T FindById(int o)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            return _dbset.Find(id);
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = null)
        {
            IQueryable<T> query = _dbset;

            if (filter != null)
            {
                query = query.Where(filter);

            }

            if (includeProperties !=null)
            {
                foreach (var inc in includeProperties.Split(new char[] { ','}, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(inc); 
                }

            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }

            return query.ToList();
        }

        public List<T> ReadAll(int skip = 0, int limit = 30)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
