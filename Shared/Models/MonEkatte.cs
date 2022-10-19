using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Table("MonEkatte")]
    public partial class MonEkatte
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("ekatteID")]
        public int EkatteId { get; set; }
        [Column("location")]
        [StringLength(255)]
        public string Location { get; set; } = null!;
        [Column("municipality")]
        [StringLength(255)]
        public string Municipality { get; set; } = null!;
        [Column("district")]
        [StringLength(255)]
        public string District { get; set; } = null!;
    }
}
