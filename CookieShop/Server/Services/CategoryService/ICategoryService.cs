using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CookieShop.Shared;

namespace CookieShop.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategories();

        Task<Category> GetCategoryByUrl(string categoryUrl);
    }
}