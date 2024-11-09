using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVet.Domain.Entities
{
    public sealed class Customer : Person
    {
        public Customer(int id, string name, string phone, string email, string address, DateTimeOffset dateOfBirth, string identificationDocument) : base(name, phone, email, address, dateOfBirth, identificationDocument)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Email = email;
            Address = address;
            DateOfBirth = dateOfBirth;
            IdentificationDocument = identificationDocument;
        }

        public ICollection<Animal>? Animals { get; set; }
    }
}
