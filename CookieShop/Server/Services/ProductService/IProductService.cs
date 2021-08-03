using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CookieShop.Shared;

namespace CookieShop.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProducts();

        Task<List<Product>> GetProductsByCategory(string categoryUrl);

        Task<Product> GetProduct(int id);

        Task<List<Product>> SearchProducts(string searchText);
    }
}
