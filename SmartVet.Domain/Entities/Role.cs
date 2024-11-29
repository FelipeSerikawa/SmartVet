namespace SmartVet.Domain.Entities
{
    public sealed class Role : Base
    {
        public Role(string description)
        {
            Description = description;
        }
        public string Description { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
