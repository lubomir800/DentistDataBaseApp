namespace DentistDataBaseApp.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public int patientId { get; set; }
        public Patient Patient { get; set; }    
        public DateTime TimeOfAppointment { get; set; }
        public int DurationInMinutes { get; set; }
        public int DentistId { get; set; }
        public Dentist Dentist { get; set; }
        public string Description { get; set; }
    }
}
