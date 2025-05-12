using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace EgyptourProject.DAL.Models
{
    public class User
    {
        public int Id { get; set; } 

        [Required]
        public string UserName { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [MinLength(8)]
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
    }
}
