using my_vaccinewebapp.Models;

namespace my_vaccinewebapp.Models
{
    public class Dependent
    {
        public int DependentId { get; set; }
        public string Name { get; set; }
        public DateTime DataOfbirth { get; set; }
        public int UserId { get; set; }
        public required User User { get; set; }

        public List<VaccineRecord> vaccineRecords { get; set; }
    }
}
