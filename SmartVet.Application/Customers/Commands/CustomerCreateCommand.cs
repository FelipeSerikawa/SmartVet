using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVet.Application.Customers.Commands
{
    public class CustomerCreateCommand : CustomerCommand
    {
        public DateTimeOffset CreatedDate { get; set; } = DateTime.UtcNow;
        public int CreatedBy { get; set; }
    }
}
