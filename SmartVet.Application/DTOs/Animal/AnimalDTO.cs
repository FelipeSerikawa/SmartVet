using SmartVet.Domain.Entities;

namespace SmartVet.Application.DTOs.Animal
{
    public class AnimalDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CustomerId { get; set; }
        public int SpecieId { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public float? Weight { get; set; }
        public Domain.Entities.Customer Customer { get; set; }
        public Domain.Entities.Specie Specie { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public int? LastModifiedBy { get; set; }
    }
}
