﻿namespace SmartVet.Application.Species.Commands
{
    public class SpecieCreateCommand : SpecieCommand
    {
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
    }
}
