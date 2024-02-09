using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ROCVESTAPI.Models;
using ROCVESTAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ROCVESTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepo;

        public ProductController(IProductRepository productRepo)
        {
            _productRepo = productRepo;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            try
            {
                var products = await _productRepo.GetProductsAsync();
                return Ok(products);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error fetching products.");
            }
        }

        [HttpGet("titles")]
        public async Task<ActionResult<List<string>>> GetProductTitles()
        {
            try
            {
                var titles = await _productRepo.GetProductTitlesAsync();
                return Ok(titles);
            }
            catch (Exception ex)
            {              
                return StatusCode(StatusCodes.Status500InternalServerError, "Error fetching product titles.");
            }
        }

       [HttpGet("titles-and-prices")]       
        public async Task<ActionResult> GetProductTitlesAndPrices()
        {
            try
            {
                var titlesAndPrices = await _productRepo.GetProductTitlesAndPricesAsync();
                return Ok(titlesAndPrices);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while fetching product titles and prices.");
            }
        }
    }
}

