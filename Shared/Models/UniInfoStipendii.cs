using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Table("UniInfoStipendii")]
    public partial class UniInfoStipendii
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("profGroupId")]
        public int ProfGroupId { get; set; }
        [Column("suma")]
        public int Suma { get; set; }

        [ForeignKey("ProfGroupId")]
        [InverseProperty("UniInfoStipendiis")]
        public virtual UniProfGroup ProfGroup { get; set; } = null!;
    }
}
