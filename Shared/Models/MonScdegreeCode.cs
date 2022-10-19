using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Table("MonScdegreeCode")]
    public partial class MonScdegreeCode
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("scDegreeID")]
        public int ScDegreeId { get; set; }
        [Column("scDegreeName")]
        [StringLength(255)]
        public string? ScDegreeName { get; set; }
    }
}
