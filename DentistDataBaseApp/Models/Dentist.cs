namespace DentistDataBaseApp.Models
{
    public class Dentist
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string describtion { get; set; }
        public List<Patient> Patients { get; set; }
    }
}
