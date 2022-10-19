using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Table("Users", Schema = "Identity")]
    [Index("NormalizedEmail", Name = "EmailIndex")]
    public partial class AppUser
    {
        public AppUser()
        {
            ChatHistoryFromUsers = new HashSet<ChatHistory>();
            ChatHistoryToUsers = new HashSet<ChatHistory>();
            Students = new HashSet<Student>();
            Teachers = new HashSet<Teacher>();
            UserClaims = new HashSet<UserClaim>();
            UserLogins = new HashSet<UserLogin>();
            UserTokens = new HashSet<UserToken>();
            Roles = new HashSet<AppRole>();
        }

        [Key]
        public string Id { get; set; } = null!;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? CreatedBy { get; set; }
        [Column(TypeName = "text")]
        public string? ProfilePictureDataUrl { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
        public bool IsActive { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
        [StringLength(256)]
        public string? UserName { get; set; }
        [StringLength(256)]
        public string? NormalizedUserName { get; set; }
        [StringLength(256)]
        public string? Email { get; set; }
        [StringLength(256)]
        public string? NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string? PasswordHash { get; set; }
        public string? SecurityStamp { get; set; }
        public string? ConcurrencyStamp { get; set; }
        public string? PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }

        [InverseProperty("FromUser")]
        public virtual ICollection<ChatHistory> ChatHistoryFromUsers { get; set; }
        [InverseProperty("ToUser")]
        public virtual ICollection<ChatHistory> ChatHistoryToUsers { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Student> Students { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Teacher> Teachers { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<UserClaim> UserClaims { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<UserLogin> UserLogins { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<UserToken> UserTokens { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("Users")]
        public virtual ICollection<AppRole> Roles { get; set; }
    }
}
