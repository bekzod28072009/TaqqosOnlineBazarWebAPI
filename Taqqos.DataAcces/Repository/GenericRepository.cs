using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Taqqos.DataAcces.AppDBContexts;
using Taqqos.DataAcces.IRepository;
using Taqqos.Domain.Commons;
using Taqqos.Domain.Enums;

namespace Taqqos.DataAcces.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : Auditable
    {
        private readonly AppDbContext dbContext;
        private readonly DbSet<T> dbSet;

        public GenericRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.dbSet = dbContext.Set<T>();
        }

        public async ValueTask<T> CreateAsync(T entity) =>
       (await dbContext.AddAsync(entity)).Entity;

        public async ValueTask<bool> DeleteAsync(Expression<Func<T, bool>> expression)
        {
            var entity = await GetAsync(expression);

            if (entity == null)
                return false;

            entity.State = ItemState.Deleted;
            Update(entity);
            await SaveChangesAsync();
            return true;
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> expression, string[] includes = null)
        {

            IQueryable<T> query = expression is null ? dbSet.Where(p => p.State != ItemState.Deleted) : dbSet.Where(p => p.State != ItemState.Deleted).Where(expression);

            if (includes != null)
                foreach (var include in includes)
                    if (!string.IsNullOrEmpty(include))
                        query = query.Include(include);
            return query;
        }

        public async ValueTask<T> GetAsync(Expression<Func<T, bool>> expression, string[] includes = null)
        {
            return await dbSet.Where(p => p.State != ItemState.Deleted).Where(expression).FirstOrDefaultAsync();
        }

        public T Update(T entity) =>
            dbSet.Update(entity).Entity;

        public async ValueTask SaveChangesAsync() =>
           await dbContext.SaveChangesAsync();
    }
}
