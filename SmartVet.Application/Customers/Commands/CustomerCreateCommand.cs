namespace SmartVet.Application.Customers.Commands
{
    public class CustomerCreateCommand : CustomerCommand
    {
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
    }
}
