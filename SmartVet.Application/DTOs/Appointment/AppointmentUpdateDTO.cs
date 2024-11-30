using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVet.Application.DTOs.Appointment
{
    public class AppointmentUpdateDTO
    {
        public int Id { get; set; }
        public int AnimalId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string? Reason { get; set; }
        public string? Diagnosis { get; set; }
        public string? Treatment { get; set; }
    }
}
