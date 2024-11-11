using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVet.Application.Species.Commands
{
    public class SpecieUpdateCommand : SpecieCommand
    {
        public int Id { get; set; }
        public DateTimeOffset? LastModifiedDate { get; set; } = DateTime.UtcNow;
    }
}
