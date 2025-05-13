using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgyptourProject.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace EgyptourProject.DAL.Repository
{
    public interface ITripRepository
    {
        public IQueryable<Trip> GetAll();
        public Trip GetById(int id);
        public void Add(Trip trip);
        public void Update(Trip trip);
        public void Delete(Trip trip);
        public void SaveChanges();
    }
}
