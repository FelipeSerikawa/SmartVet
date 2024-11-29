using MediatR;
using SmartVet.Application.Employees.Commands;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVet.Application.Employees.Handlers
{
    public class EmployeeRemoveCommandHandler : IRequestHandler<EmployeeRemoveCommand, Employee>
    {
        private readonly IBaseRepository<Employee> _baseRepository;

        public EmployeeRemoveCommandHandler(IBaseRepository<Employee> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<Employee> Handle(EmployeeRemoveCommand request, CancellationToken cancellationToken)
        {
            var employee = await _baseRepository.GetById(request.Id);

            if (employee == null) throw new ApplicationException("Employee not found to remove!");

            return await _baseRepository.Delete(employee);
        }
    }
}
