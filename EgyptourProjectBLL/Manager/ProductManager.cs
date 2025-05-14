using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgyptourProject.DAL.Repository;
using EgyptourProject.DAL.Models;

namespace EgyptourProject.BLL.Manager
{
    public class ProductManager : IProductManager
    {
        private readonly IRepository<Product> _productRepository;

        public ProductManager(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _productRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _productRepository.GetAllAsync();
        }

        public async Task AddProductAsync(Product product)
        {
            if (product.ProductPrice <= 0)
                throw new InvalidOperationException("Product price must be positive");

            await _productRepository.AddAsync(product);
        }

        public async Task UpdateProductAsync(Product product)
        {
            await _productRepository.UpdateAsync(product);
        }

        public async Task DeleteProductAsync(int id)
        {
            var product = await GetProductByIdAsync(id);
            if (product == null)
                throw new KeyNotFoundException("Product not found");

            await _productRepository.DeleteAsync(id);
        }

        public async Task SaveChangesAsync()
        {
            await _productRepository.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetFeaturedProductsAsync()
        {
            var products = await _productRepository.GetAllAsync();
            return products.Where(p => p.IsFeatured);
        }

        public async Task<IEnumerable<Product>> GetProductsByCategoryAsync(int categoryId)
        {
            var products = await _productRepository.GetAllAsync();
            return products.Where(p => p.ProductCategory.CategoryId == categoryId);
        }
    }

}
