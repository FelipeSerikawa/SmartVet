namespace SmartVet.Application.Appointments.Commands
{
    public class AppointmentCreateCommand : AppointmentCommand
    {
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
    }
}
