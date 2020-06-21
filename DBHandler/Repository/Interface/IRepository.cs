using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DBHandler
{
    public interface IRepository<T> where T : class
    {
        //IQueryable<T> GetAll(Expression<Func<T,bool>> predicate);
        IQueryable<T> GetAll();
        Task<T> Get(int id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);
    }
}
