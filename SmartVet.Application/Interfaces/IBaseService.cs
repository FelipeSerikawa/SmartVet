using SmartVet.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVet.Application.Interfaces
{
    public interface IBaseService<T> where T : class
    {
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetAll();
        Task Add(T dto);
        Task Update(T dto);
        Task Remove(int id);
    }
}
