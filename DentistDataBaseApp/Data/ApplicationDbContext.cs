using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DentistDataBaseApp.Models;

namespace DentistDataBaseApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<DentistDataBaseApp.Models.Dentist>? Dentist { get; set; }
        public DbSet<DentistDataBaseApp.Models.Patient>? Patient { get; set; }
        public DbSet<DentistDataBaseApp.Models.Appointment>? Appointment { get; set; }
    }
}