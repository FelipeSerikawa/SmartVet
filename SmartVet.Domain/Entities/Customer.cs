namespace SmartVet.Domain.Entities
{
    public sealed class Customer : Person
    {
        public Customer(string name, string phone, string email, string address, DateTime dateOfBirth, string identificationDocument) : base(name, phone, email, address, dateOfBirth, identificationDocument)
        {
            Name = name;
            Phone = phone;
            Email = email;
            Address = address;
            DateOfBirth = dateOfBirth;
            IdentificationDocument = identificationDocument;
        }

        public ICollection<Animal>? Animals { get; set; }
        public ICollection<Appointment>? Appointments { get; set; }
    }
}
