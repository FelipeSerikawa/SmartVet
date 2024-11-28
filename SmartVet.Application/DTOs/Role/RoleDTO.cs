﻿namespace SmartVet.Application.DTOs.Role
{
    public class RoleDTO
    {
        public int Id { get; set; }
        public required string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public int? LastModifiedBy { get; set; }
    }
}
