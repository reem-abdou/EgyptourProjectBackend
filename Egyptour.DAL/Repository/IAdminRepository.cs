using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgyptourProject.DAL.Data.Models;

namespace EgyptourProject.DAL.Repository
{
    public interface IAdminRepository
    {
        public IQueryable<Admin> GetAll();
        public Admin GetById(int id);
        public void Add(Admin admin);
        public void Update(Admin admin);
        public void Delete(Admin admin);
        public void SaveChanges();
    }
}
