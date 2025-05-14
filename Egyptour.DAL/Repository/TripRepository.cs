using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgyptourProject.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace EgyptourProject.DAL.Repository
{
    public class TripRepository : Repository<Trip>, IRepository<Trip>
    {
        public TripRepository(EgyptourContext context) : base(context) { }

    }
}
