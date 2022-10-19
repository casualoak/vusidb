using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Table("ChatHistory")]
    [Index("FromUserId", Name = "IX_ChatHistory_FromUserId")]
    [Index("ToUserId", Name = "IX_ChatHistory_ToUserId")]
    public partial class ChatHistory
    {
        [Key]
        public long Id { get; set; }
        public string? FromUserId { get; set; }
        public string? ToUserId { get; set; }
        public string? Message { get; set; }
        public DateTime CreatedDate { get; set; }

        [ForeignKey("FromUserId")]
        [InverseProperty("ChatHistoryFromUsers")]
        public virtual AppUser? FromUser { get; set; }
        [ForeignKey("ToUserId")]
        [InverseProperty("ChatHistoryToUsers")]
        public virtual AppUser? ToUser { get; set; }
    }
}
