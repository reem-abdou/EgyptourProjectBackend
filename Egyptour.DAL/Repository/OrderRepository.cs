using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgyptourProject.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace EgyptourProject.DAL.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly EgyptourContext _context;

        public OrderRepository(EgyptourContext context)
        {
            _context = context;
        }

        public IQueryable<Order> GetAll()
        {
            return _context.Orders.AsNoTracking();
        }
        public Order GetById(int id)
        {
            return _context.Orders.Include(o => o.OrderItems).ThenInclude(oi => oi.Item).FirstOrDefault(o => o.OrderId == id);
        }
        public void Add(Order order)
        {
            _context.Orders.Add(order);
        }

        public void Update(Order order)
        {
            _context.Orders.Update(order);
        }

        public void Delete(Order order)
        {
            _context.Orders.Remove(order);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
