using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyptourProject.BLL.Dtos.TouDTOS
{
    public class TourReadDTO
    {
        public int TripId { get; set; }
        public string TripCategory { get; set; }
        public string TripTitle { get; set; }
        public string TripDescription { get; set; }
        public string Highlights { get; set; }
        public DateTime Date { get; set; }
        public decimal TripPrice { get; set; }
        public long TripsQuantity { get; set; }
        public string ProfileImagePath { get; set; }
    }
}
