using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgyptourProject.DAL.Models;

namespace EgyptourProject.DAL.Data.Models
{
    public class Admin : User
    {
        public ICollection<Product> Products = new HashSet<Product>();
        public ICollection<Client> Clients = new HashSet<Client>();
        public ICollection<Trip> Trips = new HashSet<Trip>();
        public ICollection<Booking> Bookings = new HashSet<Booking>();
    }
}
