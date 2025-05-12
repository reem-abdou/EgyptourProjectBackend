using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyptourProject.DAL.Models
{
    public class Trip
    {
        public int TripId { get; set; }
        public string TripTitle { get; set; }
        public string TripDescription { get; set; }
        public string Destination { get; set; }
        public DateTime Date { get; set; }
        public decimal TripPrice { get; set; }
        public bool TripAvailablity { get; set; }
        public TravelAgency Company{ get; set; }
        public ICollection<Client> clients { get; set; }
    }
}
