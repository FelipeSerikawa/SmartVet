﻿namespace SmartVet.Application.DTOs.Employee
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public int? LastModifiedBy { get; set; }
    }
}
