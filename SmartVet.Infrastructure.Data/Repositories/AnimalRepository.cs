using SmartVet.Domain.Entities;
using SmartVet.Domain.Interfaces;
using SmartVet.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVet.Infrastructure.Data.Repositories
{
    public class AnimalRepository : IAnimalRepository
    {
        public AnimalRepository(AppDbContext appDbContext)
        {
        }
    }
}
