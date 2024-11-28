namespace SmartVet.Application.DTOs.Animal
{
    public class AnimalCreateDTO
    {
        public string Name { get; set; }
        public int CustomerId { get; set; }
        public int SpecieId { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public float? Weight { get; set; }
    }
}
