namespace SmartVet.Application.DTOs.Employee
{
    public class EmployeeUpdateDTO
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string IdentificationDocument { get; set; }
    }
}
