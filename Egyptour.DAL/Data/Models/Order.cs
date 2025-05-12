using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyptourProject.DAL.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Details { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public Client client { get; set; }
        public decimal OrderPrice => OrderItems?.Sum(i => i.TotalPrice) ?? 0m;
    }
}
