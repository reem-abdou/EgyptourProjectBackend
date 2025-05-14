using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgyptourProject.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace EgyptourProject.DAL.Repository
{
    public class OrderRepository : Repository<Order>, IRepository<Order>
    {
        public OrderRepository(EgyptourContext context) : base(context) { }

    }
}
