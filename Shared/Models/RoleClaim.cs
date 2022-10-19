using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Table("RoleClaims", Schema = "Identity")]
    [Index("RoleId", Name = "IX_RoleClaims_RoleId")]
    public partial class AppRoleClaim
    {
        [Key]
        public int Id { get; set; }
        public string RoleId { get; set; } = null!;
        public string? ClaimType { get; set; }
        public string? ClaimValue { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? Description { get; set; }
        public string? Group { get; set; }
        public string? LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }

        [ForeignKey("RoleId")]
        [InverseProperty("RoleClaims")]
        public virtual AppRole Role { get; set; } = null!;
    }
}
