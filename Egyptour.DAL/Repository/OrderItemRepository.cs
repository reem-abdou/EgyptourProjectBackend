using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgyptourProject.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace EgyptourProject.DAL.Repository
{
    public class OrderItemRepository : Repository<OrderItem>, IRepository<OrderItem>
    {
        public OrderItemRepository(EgyptourContext context) : base(context) { }

    }
}
