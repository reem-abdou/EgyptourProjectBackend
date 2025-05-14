using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgyptourProject.DAL.Models;
using EgyptourProject.BLL.Dtos.ProductDTO;


namespace EgyptourProject.BLL.Manager
{
    public interface IProductManager
    {
        public interface IProductManager
        {
            Task<Product> GetProductByIdAsync(int id);
            Task<IEnumerable<Product>> GetAllProductsAsync();
            Task AddProductAsync(Product product);
            Task UpdateProductAsync(Product product);
            Task DeleteProductAsync(int id);
            Task SaveChangesAsync();
            Task<IEnumerable<Product>> GetFeaturedProductsAsync();
            Task<IEnumerable<Product>> GetProductsByCategoryAsync(int categoryId);
        }
    }
}
