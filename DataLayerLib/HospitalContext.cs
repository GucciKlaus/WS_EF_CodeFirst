using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerLib
{
     public class HospitalContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Examination> Examinations { get; set; }
        public HospitalContext()
        { }
        public HospitalContext(DbContextOptions<HospitalContext> options):base(options)
        { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            Console.WriteLine($"DB OnConfiguring: IsConfigured = {optionsBuilder.IsConfigured}");
            if(optionsBuilder != null && !optionsBuilder.IsConfigured)
            {
                string conStr = @"server=(LocalDB)\mssqllocaldb;attachdbfilename=
                                C:\Users\Klaus\Dropbox\PC\Documents\HTL_V\Sperrer_MGIN\WS_EF_CodeFirst\DataLayerLib\HosDB.mdf; 
                                database=HosDB;integrated security=True;MultipleActiveResultSets=True;";
                Console.WriteLine($"Using ConnStr = {conStr}");
                optionsBuilder.UseSqlServer(conStr);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }
}
