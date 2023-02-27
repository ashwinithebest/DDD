using Application.Common.Interface;
using Domain.Product;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class CategoryServices
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryServices(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Category>> GetCategoryAsync()
        {
            var result = await categoryRepository.GetCategories();
            return result;
        }
    }
}
