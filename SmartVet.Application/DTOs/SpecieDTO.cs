using SmartVet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVet.Application.DTOs
{
    public class SpecieDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTimeOffset? LastModifiedDate { get; set; }
        public int? LastModifiedBy { get; set; }
    }
}
