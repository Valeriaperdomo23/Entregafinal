using my_vaccinewebapp.Models;

namespace my_vaccinewebapp.Models
{
    public class User
    {
        public int UserIed { get; set; }
        public required string UserName { get; set; }
        public required string Password { get; set; }
        public List<Dependent> Dependent { get; set; }
        public List<FamilyGroup> FamilyGroups { get; set; }
        public List<Allergy> Allergies { get; set; }
        public List<VaccineRecord> VaccineRecords { get; set; }
    }
}
