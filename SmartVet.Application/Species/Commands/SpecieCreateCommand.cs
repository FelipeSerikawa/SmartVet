using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVet.Application.Species.Commands
{
    public class SpecieCreateCommand : SpecieCommand
    {
        public DateTimeOffset CreatedDate { get; set; } = DateTime.UtcNow;
    }
}
