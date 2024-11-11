using SmartVet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVet.Application.DTOs
{
    public class CustomerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public string IdentificationDocument { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTimeOffset? LastModifiedDate { get; set; }
        public int? LastModifiedBy { get; set; }
    }
}
