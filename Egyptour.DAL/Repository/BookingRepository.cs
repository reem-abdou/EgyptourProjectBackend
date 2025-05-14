using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgyptourProject.DAL.Data.Models;
using EgyptourProject.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace EgyptourProject.DAL.Repository
{
    public class BookingRepository : Repository<Booking>, IRepository<Booking>
    {
        public BookingRepository(EgyptourContext context) : base(context) { }

    }
}
