using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Table("ProtocolsDelete")]
    public partial class ProtocolsDelete
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("number")]
        [StringLength(255)]
        public string Number { get; set; } = null!;
        [Column("specialityId")]
        public int SpecialityId { get; set; }
        [Column("planId")]
        public int? PlanId { get; set; }
        [Column("disciplineId")]
        public int DisciplineId { get; set; }
        [Column("isSingle")]
        public int IsSingle { get; set; }
        [Column("oLDID")]
        [StringLength(255)]
        public string? OLdid { get; set; }
        [Column("inspector")]
        [StringLength(100)]
        public string? Inspector { get; set; }
        [Column("teacherId")]
        public int? TeacherId { get; set; }
        [Column("dateNormal", TypeName = "date")]
        public DateTime? DateNormal { get; set; }
        [Column("dateFix", TypeName = "date")]
        public DateTime? DateFix { get; set; }
        [Column("dateLast", TypeName = "date")]
        public DateTime? DateLast { get; set; }
    }
}
