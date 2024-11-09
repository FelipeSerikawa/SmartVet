using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVet.Domain.Entities
{
    public sealed class Employee : Person
    {
        public Employee(string name, string phone, string email, string address, DateTimeOffset dateOfBirth, string identificationDocument) : base(name, phone, email, address, dateOfBirth, identificationDocument)
        {
        }

        public int RoleId { get; set; }
    }
}
