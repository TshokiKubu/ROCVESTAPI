using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ROCVESTAPI.Models;



namespace ROCVESTAPI.Repository
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProductsAsync();
        Task<List<string>> GetProductTitlesAsync();
       // Task<List<(string Title, decimal Price)>> GetProductTitlesAndPricesAsync();
        Task<List<object>> GetProductTitlesAndPricesAsync();

    }
}
