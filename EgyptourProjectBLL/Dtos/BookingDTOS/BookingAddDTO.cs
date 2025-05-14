using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyptourProject.BLL.Dtos.BookingDTO
{
    public class BookingAddDTO
    {
        [Required(ErrorMessage = "Status is required")]
        public string Status { get; set; }

        [Required(ErrorMessage = "Number of guests is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Guests must be at least 1")]
        public int Guests { get; set; }

        [Required(ErrorMessage = "Trip ID is required")]
        public int TripId { get; set; }

        [Required(ErrorMessage = "Client ID is required")]
        public int ClientId { get; set; }
    }
}
