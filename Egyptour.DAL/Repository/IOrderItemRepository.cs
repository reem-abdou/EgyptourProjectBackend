using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgyptourProject.DAL.Models;

namespace EgyptourProject.DAL.Repository
{
    public interface IOrderItemRepository
    {
        IQueryable<OrderItem> GetAll();
        OrderItem GetById(int id);
        void Add(OrderItem orderItem);
        void Update(OrderItem orderItem);
        void Delete(OrderItem orderItem);
        void SaveChanges();
    }
}
