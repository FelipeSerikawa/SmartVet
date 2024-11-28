namespace SmartVet.Domain.Entities
{
    public sealed class Employee : Person
    {
        public Employee(string name, string phone, string email, string address, DateTime dateOfBirth, string identificationDocument) : base(name, phone, email, address, dateOfBirth, identificationDocument)
        {
        }

        public int RoleId { get; set; }
    }
}
