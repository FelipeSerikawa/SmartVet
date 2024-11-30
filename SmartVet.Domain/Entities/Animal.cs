namespace SmartVet.Domain.Entities
{
    public sealed class Animal : Base
    {
        public Animal(string name, int customerId, int specieId, DateTime? dateOfBirth, float? weight)
        {
            Name = name;
            CustomerId = customerId;
            SpecieId = specieId;
            DateOfBirth = dateOfBirth;
            Weight = weight;
        }

        public int CustomerId { get; set; }
        public string Name { get; set; }
        public int SpecieId { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public float? Weight { get; set; }
        public Customer? Customer { get; set; }
        public Specie? Specie { get; set; }
        public ICollection<Appointment>? Appointments { get; set; }
    }
}
