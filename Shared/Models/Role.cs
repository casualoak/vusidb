using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Table("Roles", Schema = "Identity")]
    public partial class AppRole
    {
        public AppRole()
        {
            RoleClaims = new HashSet<AppRoleClaim>();
            Users = new HashSet<AppUser>();
        }

        [Key]
        public string Id { get; set; } = null!;
        [StringLength(256)]
        public string? Name { get; set; }
        [StringLength(256)]
        public string? NormalizedName { get; set; }
        public string? ConcurrencyStamp { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? Description { get; set; }
        public string? LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }

        [InverseProperty("Role")]
        public virtual ICollection<AppRoleClaim> RoleClaims { get; set; }

        [ForeignKey("RoleId")]
        [InverseProperty("Roles")]
        public virtual ICollection<AppUser> Users { get; set; }
    }
}
