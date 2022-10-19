using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Keyless]
    public partial class StudentEnrollInfoView
    {
        [Column("studentId")]
        public int StudentId { get; set; }
        [Column("studentPin")]
        [StringLength(50)]
        public string StudentPin { get; set; } = null!;
        [Column("studentName")]
        [StringLength(767)]
        public string StudentName { get; set; } = null!;
        [Column("teacherId")]
        public int? TeacherId { get; set; }
        [Column("teacherName")]
        [StringLength(1023)]
        public string TeacherName { get; set; } = null!;
        [Column("year")]
        [StringLength(50)]
        public string Year { get; set; } = null!;
        [Column("specialityId")]
        public int SpecialityId { get; set; }
        [Column("specialityName")]
        [StringLength(255)]
        public string? SpecialityName { get; set; }
        [Column("course")]
        public int Course { get; set; }
        [Column("semester")]
        public int? Semester { get; set; }
        [Column("edFormId")]
        public int EdFormId { get; set; }
        [Column("disciplineId")]
        public int DisciplineId { get; set; }
        [Column("disciplineName")]
        public string DisciplineName { get; set; } = null!;
    }
}
