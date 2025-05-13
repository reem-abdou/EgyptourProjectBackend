using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgyptourProject.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace EgyptourProject.DAL.Repository
{
    public class TripRepository:ITripRepository
    {
        private readonly EgyptourContext _context;
        public TripRepository(EgyptourContext context)
        {
            _context = context;
        }
        public IQueryable<Trip> GetAll()
        {
            return _context.Trips.AsNoTracking();
        }

        public Trip GetById(int id)
        {
            return _context.Trips.Find(id);
        }

        public void Add(Trip T)
        {
            _context.Trips.Add(T);
        }

        public void Update(Trip T)
        {
            _context.Trips.Update(T);
        }

        public void Delete(Trip T)
        {
            _context.Trips.Remove(T);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
