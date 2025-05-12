using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyptourProject.DAL.Models
{
    public class BusinessOwner:User
    {
        ICollection<Product> Products;

    }
}
