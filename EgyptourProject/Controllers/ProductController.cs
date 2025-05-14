using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EgyptourProject.DAL.Repository;
using EgyptourProject.DAL.Models;

namespace EgyptourProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IRepository<Product> _productRepository;
        public ProductController(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }


        [HttpGet()]
        public async Task<IActionResult> GetAllProducts()
        {
            try
            {
                var products = await _productRepository.GetAllAsync();
                return Ok(products);

            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Internal server error");
            }
            
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody] Product product)
        {
            try
            {
                if (product == null)
                {
                    return BadRequest("Product is null");
                }
                await _productRepository.AddAsync(product);
                await _productRepository.SaveChangesAsync();
                return CreatedAtAction(nameof(GetAllProducts), new { id = product.ProductId }, product);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest($"Error adding product");
            }
        }

    }
}
