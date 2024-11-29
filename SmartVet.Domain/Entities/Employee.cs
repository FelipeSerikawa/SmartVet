namespace SmartVet.Domain.Entities
{
    public sealed class Employee : Person
    {
        public Employee(int roleId, string name, string phone, string email, string address, DateTime dateOfBirth, string identificationDocument) : base(name, phone, email, address, dateOfBirth, identificationDocument)
        {
            RoleId = roleId;
        }

        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
