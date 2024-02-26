using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerLib
{
    public static class HospitalDBSeederExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            Console.WriteLine($"DB seeding started");
            Patient p1 = new Patient { PatientID = 1 , Firstname = "Sepp", Lastname = "Huber",       SVNR =  4823302012};
            Patient p2 = new Patient { PatientID = 2, Firstname = "Adolf", Lastname = "Gruber",      SVNR = 2343242323 };
            Patient p3 = new Patient { PatientID = 3, Firstname = "Gustav", Lastname = "Luder",      SVNR = 1556465623 };
            Patient p4 = new Patient { PatientID = 4, Firstname = "Kevin", Lastname = "Gehsteig",    SVNR = 23432432423};
            Patient p5 = new Patient { PatientID = 5, Firstname = "Kevin", Lastname = "Dunkel", SVNR = 23455552423 };
            modelBuilder.Entity<Patient>().HasData(p1,p2,p3,p4,p5);
            Doctor d1 = new Doctor { DoctorID = 1, Firstname = "Hans", Lastname = "Bert" };
            Doctor d2 = new Doctor { DoctorID = 2, Firstname = "Hans2", Lastname = "Bert2" };
            Doctor d3 = new Doctor { DoctorID = 3, Firstname = "Hans3", Lastname = "Bert3" };
            modelBuilder.Entity<Doctor>().HasData(d1, d2, d3);
            modelBuilder.Entity<Examination>().HasData(new Examination { ExaminationID = 1, Description = "Extraktion OR3"
            , PatientPatientID = 1, 
            //ExaminationPatient = 1 do not do, selbes beim doc
            DoctorDoctorID = 1});
            Console.WriteLine($"DB seeding finished");
        }
    }
}
