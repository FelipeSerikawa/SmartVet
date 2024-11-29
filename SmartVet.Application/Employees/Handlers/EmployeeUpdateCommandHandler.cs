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
    public class EmployeeUpdateCommandHandler : IRequestHandler<EmployeeUpdateCommand, Employee>
    {
        private readonly IBaseRepository<Employee> _baseRepository;

        public EmployeeUpdateCommandHandler(IBaseRepository<Employee> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<Employee> Handle(EmployeeUpdateCommand request, CancellationToken cancellationToken)
        {
            var employee = await _baseRepository.GetById(request.Id);

            if (employee == null) throw new ApplicationException("Employee not found to update!");

            employee.RoleId = request.RoleId;
            employee.Name = request.Name;
            employee.Phone = request.Phone;
            employee.Email = request.Email;
            employee.Address = request.Address;
            employee.DateOfBirth = request.DateOfBirth;
            employee.IdentificationDocument = request.IdentificationDocument;
            employee.LastModifiedBy = 0;
            employee.LastModifiedDate = DateTime.Now;

            return await _baseRepository.Update(employee);
        }
    }
}
