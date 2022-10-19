using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Table("TeacherLecture")]
    public partial class TeacherLecture
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("teacherId")]
        public int TeacherId { get; set; }
        [Column("lecturingSpecialityId")]
        public int LecturingSpecialityId { get; set; }
        [Column("lecturingEdFormId")]
        public int LecturingEdFormId { get; set; }

        [ForeignKey("LecturingEdFormId")]
        [InverseProperty("TeacherLectures")]
        public virtual MonEdForm LecturingEdForm { get; set; } = null!;
        [ForeignKey("LecturingSpecialityId")]
        [InverseProperty("TeacherLectures")]
        public virtual MonSpeciality LecturingSpeciality { get; set; } = null!;
        [ForeignKey("TeacherId")]
        [InverseProperty("TeacherLectures")]
        public virtual Teacher Teacher { get; set; } = null!;
    }
}
