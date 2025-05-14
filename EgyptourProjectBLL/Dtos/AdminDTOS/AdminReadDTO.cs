using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgyptourProject.BLL.Dtos.ClientDTOS;
using EgyptourProject.BLL.Dtos.ProductDTO;
using EgyptourProject.BLL.Dtos.UserDTOS;
using EgyptourProject.DAL.Data.Models;
using EgyptourProject.DAL.Models;

namespace EgyptourProject.BLL.Dtos.AdminDTO
{
    public class AdminReadDTO:UserReadDTO
    {
        public ICollection<ProductReadDTO> Products = new HashSet<ProductReadDTO>();
        public ICollection<ClientReadDTO> Clients = new HashSet<ClientReadDTO>();
        public ICollection<Trip> Trips = new HashSet<Trip>();

    }
}
