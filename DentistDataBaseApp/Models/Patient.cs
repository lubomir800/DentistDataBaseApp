namespace DentistDataBaseApp.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        List<Appointment> Appointments { get; set; }
        public Dentist Dentist { get; set; }
    }
}
