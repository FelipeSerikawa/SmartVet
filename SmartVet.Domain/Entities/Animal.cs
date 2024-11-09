using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVet.Domain.Entities
{
    public sealed class Animal : Base
    {
        public Animal(int id, string name, int customerId, int specieId)
        {
            Id = id;
            Name = name;
            CustomerId = customerId;
            SpecieId = specieId;
        }

        public int CustomerId { get; set; }
        public string Name { get; set; }
        public int SpecieId { get; set; }
        public DateTimeOffset? DateOfBirth { get; set; }
        public float? Weight { get; set; }
        public Customer? Customer { get; set; }
        public Specie? Specie { get; set; }
    }
}
