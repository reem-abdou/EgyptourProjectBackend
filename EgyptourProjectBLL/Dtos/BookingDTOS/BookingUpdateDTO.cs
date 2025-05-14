using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyptourProject.BLL.Dtos.BookingDTO
{
    public class BookingUpdateDTO
    {
        public int BookingId { get; set; }

        public string? Status { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Guests must be at least 1")]
        public int? Guests { get; set; }

        public int? TripId { get; set; }
        public int? ClientId { get; set; }
    }
}
