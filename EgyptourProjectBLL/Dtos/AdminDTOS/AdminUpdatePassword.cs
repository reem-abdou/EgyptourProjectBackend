using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyptourProject.BLL.Dtos.AdminDTOS
{
    public class AdminUpdatePassword
    {
        [Required(ErrorMessage = "Current password is required")]
        public string CurrentPassword { get; set; }

        [Required(ErrorMessage = "New password is required")]
        [StringLength(100, MinimumLength = 12, ErrorMessage = "Password must be at least 12 chars")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*[!@#$%^&*]).{12,}$",
            ErrorMessage = "Password requires 1 uppercase and 1 symbol")]
        public string NewPassword { get; set; }

        [Compare(nameof(NewPassword), ErrorMessage = "Passwords don't match")]
        public string ConfirmPassword { get; set; }
    }
}
