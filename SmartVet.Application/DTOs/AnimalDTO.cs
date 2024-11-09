using SmartVet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVet.Application.DTOs
{
    public class AnimalDTO
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int CustomerId { get; set; }
        public int SpecieId { get; set; }
        public DateTimeOffset? DateOfBirth { get; set; }
        public float? Weight { get; set; }
        public required Customer Customer { get; set; }
        public required Specie Specie { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTimeOffset? LastModifiedDate { get; set; }
        public int? LastModifiedBy { get; set; }
    }
}
