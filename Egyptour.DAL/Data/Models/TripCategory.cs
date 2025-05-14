using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgyptourProject.DAL.Models;


namespace EgyptourProject.DAL.Data.Models
{
    public class TripCategory
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Trip> Trips { get; set; } = new List<Trip>();   
    }
}
