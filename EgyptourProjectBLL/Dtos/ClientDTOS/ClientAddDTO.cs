using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgyptourProject.BLL.Dtos.UserDTOS;

namespace EgyptourProject.BLL.Dtos.ClientDTOS
{
    public class ClientAddDTO:UserAddDTO
    {
        [Required(ErrorMessage = "New password is required")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Password must be at least 8 chars")]
        [RegularExpression(@"^(?=.*[A-Z]).{8,}$",
            ErrorMessage = "Password requires 1 uppercase letter")]
        public string Password { get; set; }
    }
}
