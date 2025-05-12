using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgyptourProject.DAL.Data.Models;
using EgyptourProject.DAL.Models;

namespace EgyptourProject.DAL.Repository
{
    internal interface IBusinessOwnerRepository
    {
        public IQueryable<BusinessOwner> GetAll();
        public BusinessOwner GetById(int id);
        void Update(BusinessOwner B);
        void Delete(BusinessOwner B);
        void SaveChanges(BusinessOwner B);
    }
}
