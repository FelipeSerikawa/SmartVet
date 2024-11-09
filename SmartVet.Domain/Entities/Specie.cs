using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVet.Domain.Entities
{
    public sealed class Specie : Base
    {
        public Specie(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public string Name { get; set; }

        public ICollection<Animal>? Animals { get; set; }
    }
}
