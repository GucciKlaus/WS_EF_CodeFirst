
namespace DataLayerLib
{
    public class Patient
    {
        public int PatientID { get; set; }
        public long SVNR { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public List<Examination> Examinations { get; set; } = new List<Examination>();
    }

}
