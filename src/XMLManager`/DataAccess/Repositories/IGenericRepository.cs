using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public interface IGenericRepository<T> : IDisposable
    {
        IQueryable<T> All();
        IQueryable<T> Where(Expression<Func<T, bool>> filter);
        IQueryable<T> FindById(int id);
        
        void Create(T entity);
        void Delete(int id);
        void Update(T entity);
        void Save();
    }
}
