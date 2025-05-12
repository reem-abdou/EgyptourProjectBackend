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
    public class AdminRepository:IAdminRepository
    {
        private readonly EgyptourContext _context;
        public AdminRepository(EgyptourContext context)
        {
            _context = context;
        }
        public IQueryable<AdminRepository> GetAll()
        {
            return (IQueryable<AdminRepository>)(IQueryable)_context.Admins.AsNoTracking();
        }
        public Admin GetById(int id)
        {
            return _context.Admins.Find();

        }
        public void Register(Admin A)
        {
            _context.Admins.Add(A);
        }
        public void Update(Admin A)
        {

        }
        public void Delete(Admin A)
        {
            _context.Remove(A);
        }
        public void SaveChanges(Admin A)
        {
            _context.SaveChanges();
        }


    }
}
