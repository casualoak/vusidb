using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Table("MonOccupationCode")]
    public partial class MonOccupationCode
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("occupID")]
        public int OccupId { get; set; }
        [Column("occupName")]
        [StringLength(255)]
        public string? OccupName { get; set; }
    }
}
