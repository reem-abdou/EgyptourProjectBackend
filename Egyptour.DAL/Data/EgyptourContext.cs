using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgyptourProject.DAL.Data.Models;
using EgyptourProject.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace EgyptourProject.DAL
{
    public class EgyptourContext : DbContext
    {
        public EgyptourContext(DbContextOptions<EgyptourContext> options) : base(options) { }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=DESKTOP-5GNHTUN;Database=CodeFirst;Integrated Security=true;Encrypt=True");
        //    base.OnConfiguring(optionsBuilder);
        //}
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}
