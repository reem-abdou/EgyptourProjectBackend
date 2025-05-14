using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgyptourProject.DAL.Models;

namespace EgyptourProject.BLL.Dtos.OrderDTOS
{
    public class OrderUpdateDTO
    {
        public int OrderId { get; set; }
        public ICollection<OrderItem>? OrderItems { get; set; }
        public Client? client { get; set; }
    }
}
