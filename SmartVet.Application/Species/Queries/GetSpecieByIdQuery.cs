﻿using MediatR;
using SmartVet.Domain.Entities;

namespace SmartVet.Application.Species.Queries
{
    public class GetSpecieByIdQuery : IRequest<Specie>
    {
        public int Id { get; set; }

        public GetSpecieByIdQuery(int id)
        {
            Id = id;
        }
    }
}
