using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVet.Application.DTOs
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTimeOffset? LastModifiedDate { get; set; }
        public int? LastModifiedBy { get; set; }
    }
}
