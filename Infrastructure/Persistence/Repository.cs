using Application.Common.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        internal ApplicationDBContext context;
        internal DbSet<TEntity> dbSet;

        public Repository(IApplicationDBContext context)
        {
            var dataContext = context as ApplicationDBContext;
            this.context = dataContext;
            this.dbSet = dataContext.Set<TEntity>();
        }

        public virtual IQueryable<TEntity> GetItems()
        {
            return dbSet;
        }

        public virtual IQueryable<TEntity> GetItems(Expression<Func<TEntity, bool>> expression)
        {
            return dbSet.Where(expression);
        }

        public virtual TEntity GetItem(int id)
        {
            return dbSet.Find(id);
        }

        public virtual int AddItem(TEntity entity)
        {
            dbSet.Add(entity);
            return context.SaveChanges();
        }

        public virtual int UpdateItem(TEntity entity)
        {
            dbSet.Update(entity);
            return context.SaveChanges();
        }

        
    }
}
