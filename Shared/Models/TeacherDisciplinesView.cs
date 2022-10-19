using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Keyless]
    public partial class TeacherDisciplinesView
    {
        [Column("teacherid")]
        public int? Teacherid { get; set; }
        [Column("year")]
        public int? Year { get; set; }
        [Column("course")]
        public int Course { get; set; }
        [Column("courseName")]
        [StringLength(100)]
        public string CourseName { get; set; } = null!;
        [Column("semester")]
        public int? Semester { get; set; }
        [Column("abbreviation")]
        public string Abbreviation { get; set; } = null!;
        [Column("disciplineId")]
        public int DisciplineId { get; set; }
        [Column("specialityId")]
        public int SpecialityId { get; set; }
        [Column("disciplineName")]
        public string DisciplineName { get; set; } = null!;
        [Column("specialityName")]
        [StringLength(255)]
        public string? SpecialityName { get; set; }
        [Column("edFormId")]
        public int EdFormId { get; set; }
        [Column("edFormName")]
        [StringLength(255)]
        public string? EdFormName { get; set; }
    }
}
