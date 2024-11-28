namespace SmartVet.Domain.Entities
{
    public sealed class Specie : Base
    {
        public Specie(string name)
        {
            Name = name;
        }
        public string Name { get; set; }

        public ICollection<Animal>? Animals { get; set; }
    }
}
