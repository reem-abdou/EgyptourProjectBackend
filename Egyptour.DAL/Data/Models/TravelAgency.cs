using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyptourProject.DAL.Models
{
    public class TravelAgency:User
    {
        public int AgencyId { get; set; }
        public string AgencyName { get; set; }
        public ICollection<Trip> Trips { get; set; }

    }
}
