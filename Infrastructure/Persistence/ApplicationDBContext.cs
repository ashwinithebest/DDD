using Application.Common.Interface;
using Domain.Master;
using Domain.Product;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class ApplicationDBContext : DbContext , IApplicationDBContext
    {
        private DateTime _currentDateTime;
        //#region Ctor

        public ApplicationDBContext (DbContextOptions<ApplicationDBContext> options) :base(options)
        {
            _currentDateTime = DateTime.Now;
        }
        public DbSet<AppSetting> AppSettings { get; set; } //Master
        public DbSet<Category> Categories { get; set; } //Product
        /// <summary>
        /// Creates a DbSet that can be used to query and save instance of entity
        /// </summary>
        /// 
        //DbSet<TEntity> Set<TEntity>() where TEntity : class;
        public Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDBContext).Assembly);
        }








    }

}
