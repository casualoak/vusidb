using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Table("MonEdPeriod")]
    public partial class MonEdPeriod
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("edPeriodID", TypeName = "decimal(10, 1)")]
        public decimal EdPeriodId { get; set; }
        [Column("edPeriodName")]
        [StringLength(10)]
        public string EdPeriodName { get; set; } = null!;
    }
}
