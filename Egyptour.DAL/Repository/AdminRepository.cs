using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EgyptourProject.DAL.Data.Models;

namespace EgyptourProject.DAL.Repository
{
    public class AdminRepository: IAdminRepository
    {
        private readonly EgyptourContext _context;
        public AdminRepository(EgyptourContext context)
        {
            _context = context;
        }
        public IQueryable<Admin> GetAll()
        {
            return _context.Admins.AsNoTracking();
        }
        public Admin GetById(int id)
        {
            return _context.Admins.Find(id);
        }
        public void Add(Admin admin)
        {
            _context.Admins.Add(admin);
        }
        public void Update(Admin admin)
        {
            _context.Admins.Update(admin);
        }
        public void Delete(Admin admin)
        {
            _context.Admins.Remove(admin);
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
