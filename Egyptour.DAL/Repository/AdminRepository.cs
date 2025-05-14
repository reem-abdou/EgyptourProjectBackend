using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EgyptourProject.DAL.Data.Models;
using EgyptourProject.DAL.Models;

namespace EgyptourProject.DAL.Repository
{
    public class AdminRepository : Repository<Admin>, IRepository<Admin>
    {
        public AdminRepository(EgyptourContext context) : base(context) { }

    }
}
