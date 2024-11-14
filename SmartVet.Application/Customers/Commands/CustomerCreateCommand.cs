using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVet.Application.Customers.Commands
{
    public class CustomerCreateCommand : CustomerCommand
    {
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
    }
}
