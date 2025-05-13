using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgyptourProject.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace EgyptourProject.DAL.Repository
{
    public interface IProductRepository
    {
        public IQueryable<Product> GetAll();
        public Product GetById(int id);
        public void Add(Product product);
        public void Update(Product product);
        public void Delete(Product product);
        public void SaveChanges();
    }
}
