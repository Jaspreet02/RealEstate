using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DBHandler
{
  public abstract class AbstractRepository<TContext, TEntity> : IRepository<TEntity>
        where TEntity : class  where TContext : DbContext
    {
       protected readonly TContext context;

       public AbstractRepository(TContext options)
       {
           context = options;
       }

        public async Task<TEntity> Add(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> Delete(int id)
        {
            var entity = await context.Set<TEntity>().FindAsync(id);
            if (entity == null)
            {
                return entity;
            }

            context.Set<TEntity>().Remove(entity);
            await context.SaveChangesAsync();

            return entity;
        }

        public async Task<TEntity> Get(int id)
        {
            return await context.Set<TEntity>().FindAsync(id);
        }

        //public  IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate)
        //{
        //    return context.Set<TEntity>().Where(predicate);
        //}

        public IQueryable<TEntity> GetAll()
        {
            return context.Set<TEntity>();
        }

        public async Task<TEntity> Update(TEntity entity)
        {

            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return entity;
        }
    }
}
