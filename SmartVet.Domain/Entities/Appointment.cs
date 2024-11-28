namespace SmartVet.Domain.Entities
{
    public sealed class Appointment : Base
    {
        public int CustomerId { get; set; }
        public int AnimalId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public required string Reason { get; set; }
        public string? Diagnosis { get; set; }
        public string? Treatment { get; set; }
        public required Customer Customer { get; set; }
        public required Animal Animal { get; set; }
        public required Employee Employee { get; set; }
    }
}
