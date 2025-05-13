using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgyptourProject.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace EgyptourProject.DAL.Repository
{
    public class ProductRepository:IProductRepository
    {
        private readonly EgyptourContext _context;
        public ProductRepository(EgyptourContext context)
        {
            _context = context;
        }
        public IQueryable<Product> GetAll()
        {
            return _context.Products.AsNoTracking();
        }

        public Product GetById(int id)
        {
            return _context.Products.Find(id);
        }

        public void Add(Product P)
        {
            _context.Products.Add(P);
        }

        public void Update(Product P)
        {
            _context.Products.Update(P);
        }

        public void Delete(Product P)
        {
            _context.Products.Remove(P);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }
}
