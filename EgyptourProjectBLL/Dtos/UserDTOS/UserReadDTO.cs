using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgyptourProject.BLL.Dtos.BookingDTO;

namespace EgyptourProject.BLL.Dtos.UserDTOS
{
    public class UserReadDTO
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<BookingReadDTO> TripList { get; set; } = new List<BookingReadDTO>();
    }
}
