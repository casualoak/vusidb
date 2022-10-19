using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    public partial class PlanDiscipline
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("planId")]
        public int PlanId { get; set; }
        [Column("disciplineId")]
        public int DisciplineId { get; set; }
        [Column("academicEmployment")]
        [StringLength(255)]
        public string AcademicEmployment { get; set; } = null!;
        [Column("outdoorJobs")]
        [StringLength(255)]
        public string OutdoorJobs { get; set; } = null!;
        [Column("lectures")]
        [StringLength(255)]
        public string Lectures { get; set; } = null!;
        [Column("seminars")]
        [StringLength(255)]
        public string Seminars { get; set; } = null!;
        [Column("credits")]
        [StringLength(255)]
        public string Credits { get; set; } = null!;
        [Column("typeId")]
        public int TypeId { get; set; }
        [Column("note")]
        public string? Note { get; set; }
        [Column("teacherName")]
        [StringLength(255)]
        public string? TeacherName { get; set; }
        [Column("id_teachers")]
        public int IdTeachers { get; set; }

        [ForeignKey("DisciplineId")]
        [InverseProperty("PlanDisciplines")]
        public virtual UniDiscipline Discipline { get; set; } = null!;
        [ForeignKey("PlanId")]
        [InverseProperty("PlanDisciplines")]
        public virtual Plan Plan { get; set; } = null!;
        [ForeignKey("TypeId")]
        [InverseProperty("PlanDisciplines")]
        public virtual MonCustomDisciplineType Type { get; set; } = null!;
    }
}
