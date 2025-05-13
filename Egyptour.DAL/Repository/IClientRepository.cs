using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgyptourProject.DAL.Models;

namespace EgyptourProject.DAL.Repository
{
    public interface IClientRepository
    {
        public IQueryable<Client> GetAll();
        public Client GetById(int id);
        public void Add(Client C);
        public void Update(Client C);
        public void Delete(Client C);
        public void SaveChanges();
    }
}
