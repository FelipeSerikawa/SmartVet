using AutoMapper;
using SmartVet.Application.DTOs;
using SmartVet.Application.Interfaces;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVet.Application.Services
{
    public class AnimalService : IBaseService<AnimalDTO>
    {
        private readonly IBaseRepository<Animal> _baseRepository;
        private readonly IMapper _mapper;

        public AnimalService(IBaseRepository<Animal> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }

        public async Task Add(AnimalDTO entity)
        {
            var animalEntity = _mapper.Map<Animal>(entity);
            await _baseRepository.Add(animalEntity);
        }

        public async Task Delete(int id)
        {
            var animalEntity = _baseRepository.GetById(id).Result;
            await _baseRepository.Delete(animalEntity);
        }

        public async Task<AnimalDTO> GetById(int id)
        {
            var animalEntity = await _baseRepository.GetById(id);
            return _mapper.Map<AnimalDTO>(animalEntity);
        }

        public async Task Update(AnimalDTO entity)
        {
            var animalEntity = _mapper.Map<Animal>(entity);
            await _baseRepository.Update(animalEntity);
        }
    }
}
