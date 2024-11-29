namespace SmartVet.Application.Employees.Commands
{
    public class EmployeeUpdateCommand : EmployeeCommand
    {
        public EmployeeUpdateCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
