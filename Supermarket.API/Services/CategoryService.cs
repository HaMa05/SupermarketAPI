using Supermarket.API.Domain.Models;
using Supermarket.API.Domain.Repositories;
using Supermarket.API.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.API.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRespository _categoryRespository;

        public CategoryService(ICategoryRespository categoryRespository)
        {
            this._categoryRespository = categoryRespository;
        }
        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _categoryRespository.ListAsync();
        }
    }
}
