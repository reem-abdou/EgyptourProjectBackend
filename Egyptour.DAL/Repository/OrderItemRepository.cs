using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgyptourProject.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace EgyptourProject.DAL.Repository
{
    public class OrderItemRepository:IOrderItemRepository
    {
        private readonly EgyptourContext _context;

        public OrderItemRepository(EgyptourContext context)
        {
            _context = context;
        }

        public IQueryable<OrderItem> GetAll()
        {
            return _context.OrderItems.AsNoTracking();
        }

        public OrderItem GetById(int id)
        {
            return _context.OrderItems.Find(id);
        }

        public void Add(OrderItem orderItem)
        {
            _context.OrderItems.Add(orderItem);
        }

        public void Update(OrderItem orderItem)
        {
            _context.OrderItems.Update(orderItem);
        }

        public void Delete(OrderItem orderItem)
        {
            _context.OrderItems.Remove(orderItem);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }
}
