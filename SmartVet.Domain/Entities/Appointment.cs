namespace SmartVet.Domain.Entities
{
    public sealed class Appointment : Base
    {
        public Appointment(int animalId, int employeeId, DateTime appointmentDate, string? reason, string? diagnosis, string? treatment)
        {
            AnimalId = animalId;
            EmployeeId = employeeId;
            AppointmentDate = appointmentDate;
            Reason = reason;
            Diagnosis = diagnosis;
            Treatment = treatment;
        }

        public int AnimalId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string? Reason { get; set; }
        public string? Diagnosis { get; set; }
        public string? Treatment { get; set; }
        public Animal? Animal { get; set; }
        public Employee? Employee { get; set; }
    }
}
