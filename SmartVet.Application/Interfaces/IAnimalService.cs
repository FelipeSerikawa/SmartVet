using SmartVet.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVet.Application.Interfaces
{
    public interface IAnimalService
    {
        Task<AnimalDTO> GetAnimal(int id);
    }
}
