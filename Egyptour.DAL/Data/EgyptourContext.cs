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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-5GNHTUN;Database=CodeFirst;Integrated Security=true;Encrypt=True");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<TravelAgency> TravelAgencies { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<BusinessOwner> Shops { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(u => u.Email)
                    .IsRequired();

                entity.Property(u => u.UserName)
                    .IsRequired();

                entity.Property(u => u.Email)
                    .IsRequired();
            });

            modelBuilder.Entity<Trip>(entity =>
            {
                entity.Property(u => u.TripDescription)
                    .HasMaxLength(1000);
            }


            );
        }
    }
}
