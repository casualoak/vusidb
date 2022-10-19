using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Keyless]
    public partial class SchedeulerViewAllView
    {
        public int Id { get; set; }
        [StringLength(250)]
        public string Subject { get; set; } = null!;
        [StringLength(50)]
        public string? Location { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime StartTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime EndTime { get; set; }
        [StringLength(250)]
        public string? Description { get; set; }
        [StringLength(250)]
        public string? RecurrenceRule { get; set; }
        [StringLength(250)]
        public string? RecurrenceException { get; set; }
        [Column("RecurrenceID")]
        public int? RecurrenceId { get; set; }
        [Column("userid")]
        public int? Userid { get; set; }
        public bool? IsAllDay { get; set; }
        public bool? IsReadonly { get; set; }
    }
}
