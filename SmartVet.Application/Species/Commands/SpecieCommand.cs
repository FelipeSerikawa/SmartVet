﻿using MediatR;
using SmartVet.Domain.Entities;

namespace SmartVet.Application.Species.Commands
{
    public abstract class SpecieCommand : IRequest<Specie>
    {
        public string? Name { get; set; }
        public int? CreatedBy { get; set; }
        public int? LastModifiedBy { get; set; }
    }
}
