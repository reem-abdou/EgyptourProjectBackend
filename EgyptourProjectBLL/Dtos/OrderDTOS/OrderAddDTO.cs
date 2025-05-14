using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgyptourProject.DAL.Models;

namespace EgyptourProject.BLL.Dtos.OrderDTOS
{
    public class OrderAddDTO
    {
        [Required(ErrorMessage = "Order items are required")]
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        [Required(ErrorMessage = "Client is required")]
        public Client client { get; set; }
    }
}
