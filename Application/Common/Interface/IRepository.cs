using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interface
{
    public interface IRepository<TEntity>
    {
        IQueryable<TEntity> GetItems();
        IQueryable<TEntity> GetItems(Expression<Func<TEntity, bool>> expression);
        int AddItem(TEntity item);
        int UpdateItem(TEntity entity);
        TEntity GetItem(int id);
    }
}


