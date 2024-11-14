using SmartVet.Application.DTOs.Employee;

namespace SmartVet.Application.DTOs.Appointment
{
    public class AppointmentDTO
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int AnimalId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public required string Reason { get; set; }
        public string? Diagnosis { get; set; }
        public string? Treatment { get; set; }
        public Domain.Entities.Customer Customer { get; set; }
        public Domain.Entities.Animal Animal { get; set; }
        public EmployeeDTO Employee { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public int? LastModifiedBy { get; set; }
    }
}
