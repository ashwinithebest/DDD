using Application.Common.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    //public class UnitOfWork : IUnitOfWork
    //{
    //    private readonly ApplicationDBContext _context;
    //    public UnitOfWork(ApplicationDBContext context)
    //    {
    //        _context = context;
    //        Category = new AppSettingsRepository(_context);
    //        Projects = new CategoryRepository(_context);
    //    }
    //    public AppSettingsRepository Appsetting get; private set; }
    //    public IProjectRepository Projects { get; private set; }
    //    public int Complete()
    //    {
    //        return _context.SaveChanges();
    //    }
    //    public void Dispose()
    //    {
    //        _context.Dispose();
    //    }
    //}
}
