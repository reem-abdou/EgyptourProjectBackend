using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgyptourProject.DAL.Models;

namespace EgyptourProject.BLL.Dtos.OrderItemDTOS
{
    public class OrderItemUpdateDTO
    {
        public int OrderId { get; set; }

        public ICollection<OrderItem>? OrderItems { get; set; }

        public Client? client { get; set; }
    }
}
