using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using EgyptourProject.DAL.Models;

namespace EgyptourProject.BLL.Dtos.OrderItemDTOS
{
    public class OrderItemAddDTO
    {
        [Required(ErrorMessage = "Order items are required")]
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        [Required(ErrorMessage = "Client information is required")]
        public Client client { get; set; }
    }
}
