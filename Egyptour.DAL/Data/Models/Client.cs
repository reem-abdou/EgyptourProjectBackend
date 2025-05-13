using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgyptourProject.DAL.Data.Models;

namespace EgyptourProject.DAL.Models
{
    public class Client:User
    {
        public ICollection<Booking> TripList { get; set; } = new List<Booking>();
        public ICollection<Order> OrderList { get; set; } = new List<Order>();

    }
}
