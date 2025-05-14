using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgyptourProject.BLL.Dtos.ClientDTOS;
using EgyptourProject.DAL.Models;

namespace EgyptourProject.BLL.Dtos.BookingDTO
{
    public class BookingReadDTO
    {
        public int BookingId { get; set; }
        public string Status { get; set; }
        public int Guests { get; set; }
        public int TripId { get; set; }
        public Trip Trip { get; set; }  
       public int ClientId { get; set; }
        public ClientReadDTO Client { get; set; }
    }
}
