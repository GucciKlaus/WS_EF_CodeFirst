using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerLib
{
    public class Examination
    {
        public int ExaminationID { get; set; }
        public string? Description { get; set; }
        public int PatientPatientID { get; set; }
        public Patient? ExaminationPatient { get; set; }
        public int DoctorDoctorID { get; set; }
        public Doctor? ExaminationDoctor { get; set; }
    }
}
