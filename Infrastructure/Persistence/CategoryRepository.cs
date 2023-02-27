using Application.Common.Interface;
using Domain.Product;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDBContext context) : base(context)
        {
        }
        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await GetItems().ToListAsync();
        }

      
    }
}

