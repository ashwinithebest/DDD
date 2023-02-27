using Domain.Master;
using Domain.Product;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interface
{
    public interface IApplicationDBContext
    {
        DbSet<AppSetting> AppSettings { get; set; } //Master
        DbSet<Category> Categories { get; set; } //Product
        /// <summary>
        /// Creates a DbSet that can be used to query and save instance of entity
        /// </summary>
        /// 
       // DbSet<TEntity> Set<TEntity>() where TEntity : class;
        Task<int> SaveChangesAsync();
    }
}
