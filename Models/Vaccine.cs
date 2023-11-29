using my_vaccinewebapp.Models;

namespace my_vaccinewebapp.Models
{
    public class Vaccine
    {
        public int VaccineId { get; set; }
        public string Name { get; set; }
        public List<VaccineCategory> Categories { get; set; }
    }
}
