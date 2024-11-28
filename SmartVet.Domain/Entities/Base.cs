namespace SmartVet.Domain.Entities
{
    public abstract class Base
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public int? LastModifiedBy { get; set; }
    }
}
