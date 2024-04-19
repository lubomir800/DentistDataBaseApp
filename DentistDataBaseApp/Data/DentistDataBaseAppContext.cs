using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DentistDataBaseApp.Models;

namespace DentistDataBaseApp.Data
{
    public class DentistDataBaseAppContext : DbContext
    {
        public DentistDataBaseAppContext (DbContextOptions<DentistDataBaseAppContext> options)
            : base(options)
        {
        }

        public DbSet<DentistDataBaseApp.Models.Dentist> Dentist { get; set; } = default!;

        public DbSet<DentistDataBaseApp.Models.Patient>? Patient { get; set; }

        public DbSet<DentistDataBaseApp.Models.Appointment>? Appointment { get; set; }
    }
}
