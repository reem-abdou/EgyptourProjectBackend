using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgyptourProject.BLL.Dtos.UserDTOS;

namespace EgyptourProject.BLL.Dtos.AdminDTO
{
    public class AdminAddDTO:UserAddDTO
    {
        [Required(ErrorMessage = "New password is required")]
        [StringLength(100, MinimumLength = 12, ErrorMessage = "Password must be at least 12 chars")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*[!@#$%^&*]).{12,}$",
            ErrorMessage = "Password requires 1 uppercase and 1 symbol")]
        public string Password { get; set; }
    }
}
