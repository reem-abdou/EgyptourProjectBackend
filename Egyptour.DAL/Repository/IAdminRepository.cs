using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgyptourProject.DAL.Data.Models;
using EgyptourProject.DAL.Models;

namespace EgyptourProject.DAL.Repository
{
    public interface IAdminRepository
    {
        public IQueryable<AdminRepository> GetAll();
        public Admin GetById(int id);
        void Update(Admin A);
        void Delete(Admin A);
        void SaveChanges(Admin A);
    }
}
