using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Table("UniInfoMobilnost")]
    public partial class UniInfoMobilnost
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("profGroupId")]
        public int ProfGroupId { get; set; }
        [Column("studentiVUvProgrami")]
        public int StudentiVuvProgrami { get; set; }
        [Column("studentiES")]
        public int StudentiEs { get; set; }
        [Column("programiVU")]
        public int ProgramiVu { get; set; }
        [Column("programiES")]
        public int ProgramiEs { get; set; }

        [ForeignKey("ProfGroupId")]
        [InverseProperty("UniInfoMobilnosts")]
        public virtual UniProfGroup ProfGroup { get; set; } = null!;
    }
}
