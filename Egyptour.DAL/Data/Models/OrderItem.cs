using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyptourProject.DAL.Models
{
    public class OrderItem
    {
        public Product Item {  get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice => Item?.ProductPrice*Quantity ?? 0;
    }
}
