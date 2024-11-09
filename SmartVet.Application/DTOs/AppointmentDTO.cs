using SmartVet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVet.Application.DTOs
{
    public class AppointmentDTO
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int AnimalId { get; set; }
        public int EmployeeId { get; set; }
        public DateTimeOffset AppointmentDate { get; set; }
        public required string Reason { get; set; }
        public string? Diagnosis { get; set; }
        public string? Treatment { get; set; }
        public required Customer Customer { get; set; }
        public required Animal Animal { get; set; }
        public required EmployeeDTO Employee { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTimeOffset? LastModifiedDate { get; set; }
        public int? LastModifiedBy { get; set; }
    }
}
