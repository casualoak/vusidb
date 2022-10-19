using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Index("ProtocolId", Name = "IND_kia_protocol_studens_protocolid")]
    public partial class ProtocolStudent
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("protocolId")]
        public int ProtocolId { get; set; }
        [Column("studentId")]
        public int StudentId { get; set; }
        [Column("credits")]
        [StringLength(50)]
        public string? Credits { get; set; }
        [Column("lectures")]
        [StringLength(255)]
        public string? Lectures { get; set; }
        [Column("seminars")]
        [StringLength(255)]
        public string? Seminars { get; set; }
        [Column("score_1", TypeName = "decimal(18, 2)")]
        public decimal? Score1 { get; set; }
        [Column("score_2", TypeName = "decimal(18, 2)")]
        public decimal? Score2 { get; set; }
        [Column("score_3", TypeName = "decimal(18, 2)")]
        public decimal? Score3 { get; set; }

        [ForeignKey("ProtocolId")]
        [InverseProperty("ProtocolStudents")]
        public virtual Protocol Protocol { get; set; } = null!;
        [ForeignKey("StudentId")]
        [InverseProperty("ProtocolStudents")]
        public virtual Student Student { get; set; } = null!;
    }
}
