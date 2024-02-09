using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ROCVESTAPI.Models;
using Microsoft.EntityFrameworkCore;
using ROCVESTAPI.Data;

namespace ROCVESTAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public ProductRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            try
            {
                return await _dbContext.Products.ToListAsync();
            }
            catch (Exception ex)
            {                
                throw new Exception("Error fetching products.", ex);
            }
        }

        public async Task<List<string>> GetProductTitlesAsync()
        {
            try
            {
                return await _dbContext.Products.Select(p => p.Title).ToListAsync();
            }
            catch (Exception ex)
            {            
                throw new Exception("Error fetching product titles.", ex);
            }
        }

        public async Task<List<object>> GetProductTitlesAndPricesAsync()
        {
            try
            {
                var products = await _dbContext.Products
                    .Select(p => new { Title = p.Title, Price = p.Price }) // Project data into the expected format
                    .ToListAsync();

                return products.Cast<object>().ToList();
            }
            catch (Exception ex)
            {              
                throw new Exception("Error fetching product titles and prices.", ex);
            }
        }

    }
}
