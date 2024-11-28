namespace SmartVet.Application.DTOs.Customer
{
    public class CustomerCreateDTO
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string IdentificationDocument { get; set; }
    }
}
