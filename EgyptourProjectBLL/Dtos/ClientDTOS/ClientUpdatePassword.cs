using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyptourProject.BLL.Dtos.ClientDTOS
{
    public class ClientUpdatePassword
    {
        [Required(ErrorMessage = "Current password is required")]
        public string CurrentPassword { get; set; }

        [Required(ErrorMessage = "New password is required")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Password must be at least 8 chars")]
        [RegularExpression(@"^(?=.*[A-Z]).{8,}$",
            ErrorMessage = "Password requires 1 uppercase letter")]
        public string NewPassword { get; set; }

        [Compare(nameof(NewPassword), ErrorMessage = "Passwords don't match")]
        public string ConfirmPassword { get; set; }
    }
}
