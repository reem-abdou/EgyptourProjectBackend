using EgyptourProject.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace EgyptourProject.DAL.Repository
{
    public class ProductRepository : Repository<Product>, IRepository<Product>
    {
        public ProductRepository(EgyptourContext context) : base(context) { }

    }
}
