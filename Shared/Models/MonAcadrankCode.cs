using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Table("MonAcadrankCode")]
    public partial class MonAcadrankCode
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("acadRankID")]
        public int AcadRankId { get; set; }
        [Column("acadRankName")]
        [StringLength(255)]
        public string AcadRankName { get; set; } = null!;
    }
}
