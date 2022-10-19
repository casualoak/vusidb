using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Keyless]
    public partial class ProtocolDisciplinePlansView
    {
        [Column("protocols_id")]
        public int? ProtocolsId { get; set; }
        [Column("score_1", TypeName = "decimal(18, 2)")]
        public decimal? Score1 { get; set; }
        [Column("score_2", TypeName = "decimal(18, 2)")]
        public decimal? Score2 { get; set; }
        [Column("score_3", TypeName = "decimal(18, 2)")]
        public decimal? Score3 { get; set; }
        [Column("firstName")]
        [StringLength(255)]
        public string? FirstName { get; set; }
        [Column("middleName")]
        [StringLength(255)]
        public string? MiddleName { get; set; }
        [Column("lastName")]
        [StringLength(255)]
        public string? LastName { get; set; }
        [Column("name")]
        public string? Name { get; set; }
        [Column("isSingle")]
        public int? IsSingle { get; set; }
        [Column("year")]
        [StringLength(255)]
        public string? Year { get; set; }
        [Column("course")]
        public int? Course { get; set; }
        [Column("semester")]
        [StringLength(255)]
        public string? Semester { get; set; }
        [Column("number")]
        [StringLength(255)]
        public string? Number { get; set; }
        [Column("disciplineId")]
        public int? DisciplineId { get; set; }
        [Column("planId")]
        public int? PlanId { get; set; }
        [Column("studentId")]
        public int StudentId { get; set; }
    }
}
