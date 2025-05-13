using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgyptourProject.DAL.Data.Models;

namespace EgyptourProject.DAL.Repository
{
    public interface IBookingRepository
    {
        public IQueryable<Booking> GetAll();
        public Booking GetById(int id);
        public void Add(Booking booking);
        public void Update(Booking booking);
        public void Delete(Booking booking);
        public void SaveChanges();
    }
}
