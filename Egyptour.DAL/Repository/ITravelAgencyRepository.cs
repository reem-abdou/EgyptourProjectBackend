using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgyptourProject.DAL.Models;

namespace EgyptourProject.DAL.Repository
{
    public interface ITravelAgencyRepository
    {
        public IQueryable<TravelAgency> GetAll();
        public TravelAgency GetById(int id);
        void Update(TravelAgency T);
        void Delete(TravelAgency T);
        void SaveChanges(TravelAgency T);
    }
}
