using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Index("UserId", Name = "AuditTrailsUserId")]
    public partial class AuditTrail
    {
        [Key]
        public int Id { get; set; }
        [StringLength(250)]
        public string? UserId { get; set; }
        [StringLength(100)]
        public string? Type { get; set; }
        [StringLength(100)]
        public string? TableName { get; set; }
        public DateTime DateTime { get; set; }
        public string? OldValues { get; set; }
        public string? NewValues { get; set; }
        [StringLength(2048)]
        public string? AffectedColumns { get; set; }
        [StringLength(250)]
        public string? PrimaryKey { get; set; }
    }
}
