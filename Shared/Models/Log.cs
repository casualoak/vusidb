using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    public partial class Log
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("oldObj")]
        public string? OldObj { get; set; }
        [Column("newObj")]
        public string? NewObj { get; set; }
        [Column("adminId")]
        public int AdminId { get; set; }
        [Column("dateIn")]
        [Precision(0)]
        public DateTime DateIn { get; set; }
        [Column("operation")]
        [StringLength(6)]
        public string Operation { get; set; } = null!;
        [Column("className")]
        public string ClassName { get; set; } = null!;
    }
}
