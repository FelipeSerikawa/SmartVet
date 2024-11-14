using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVet.Domain.Entities
{
    public abstract class Person : Base
    {
        protected Person(string name, string phone, string email, string address, DateTime dateOfBirth, string identificationDocument)
        {
            Name = name;
            Phone = phone;
            Email = email;
            Address = address;
            DateOfBirth = dateOfBirth;
            IdentificationDocument = identificationDocument;
        }

        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string IdentificationDocument { get; set; }
    }
}
