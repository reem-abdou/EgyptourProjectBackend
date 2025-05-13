using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgyptourProject.DAL.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EgyptourProject.DAL.Repository
{
    public class BookingRepository:IBookingRepository
    {
        private readonly EgyptourContext _context;
        public BookingRepository(EgyptourContext context)
        {
            _context = context;
        }
        public IQueryable<Booking> GetAll()
        {
            return _context.Bookings.AsNoTracking();
        }
        public Booking GetById(int id)
        {
            return _context.Bookings.Find(id);
        }
        public void Add(Booking booking)
        {
            _context.Bookings.Add(booking);
        }
        public void Update(Booking booking)
        {
            _context.Bookings.Update(booking);
        }
        public void Delete(Booking booking)
        {
            _context.Bookings.Remove(booking);
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
