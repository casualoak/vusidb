using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Table("UserTokens", Schema = "Identity")]
    public partial class UserToken
    {
        [Key]
        public string UserId { get; set; } = null!;
        [Key]
        public string LoginProvider { get; set; } = null!;
        [Key]
        public string Name { get; set; } = null!;
        public string? Value { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("UserTokens")]
        public virtual AppUser User { get; set; } = null!;
    }
}
