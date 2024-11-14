﻿using MediatR;
using SmartVet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVet.Application.Species.Queries
{
    public class GetSpecieQuery : IRequest<IEnumerable<Specie>>
    {
    }
}