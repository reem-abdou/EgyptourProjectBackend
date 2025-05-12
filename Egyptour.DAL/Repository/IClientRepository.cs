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
        void Update(Client C);
        void Delete(Client C);
        void SaveChanges(Client C);
    }
}
