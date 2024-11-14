using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVet.Application.Customers.Commands
{
    public class CustomerUpdateCommand : CustomerCommand
    {
        public int Id { get; set; }
    }
}
