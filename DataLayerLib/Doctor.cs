using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerLib
{
    public class Doctor
    {
        public int DoctorID { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set;}
        public List<Examination> Examinations { get; set; } = new List<Examination>();
    }
}
