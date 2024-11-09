using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVet.Domain.Entities
{
    public abstract class Base
    {
        public int Id { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTimeOffset? LastModifiedDate { get; set; }
        public int? LastModifiedBy { get; set; }
    }
}
