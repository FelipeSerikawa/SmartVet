namespace SmartVet.Application.Animals.Commands
{
    public class AnimalCreateCommand : AnimalCommand
    {
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
    }
}
