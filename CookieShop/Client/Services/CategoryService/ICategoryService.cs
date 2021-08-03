using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CookieShop.Shared;

namespace CookieShop.Client.Services.CategoryService
{
    public interface ICategoryService
    {
        List<Category> Categories {get; set;}
        Task LoadCategories();
    }
}
