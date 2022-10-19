using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Table("StudentEnrolled")]
    public partial class StudentEnrolled
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("studentId")]
        public int StudentId { get; set; }
        [Column("year")]
        [StringLength(50)]
        public string Year { get; set; } = null!;
        [Column("specialityId")]
        public int SpecialityId { get; set; }
        [Column("course")]
        public int Course { get; set; }
        [Column("specialityNum")]
        public int SpecialityNum { get; set; }
        [Column("studyTypeId")]
        public int StudyTypeId { get; set; }
        [Column("orderNum")]
        [StringLength(255)]
        public string? OrderNum { get; set; }
        [Column("score")]
        [StringLength(50)]
        public string? Score { get; set; }
        [Column("change_date")]
        [Precision(0)]
        public DateTime ChangeDate { get; set; }
        [Column("orderDate", TypeName = "date")]
        public DateTime? OrderDate { get; set; }
        [Column("orderEndDate", TypeName = "date")]
        public DateTime? OrderEndDate { get; set; }

        [ForeignKey("SpecialityId")]
        [InverseProperty("StudentEnrolleds")]
        public virtual UniSpeciality Speciality { get; set; } = null!;
        [ForeignKey("StudentId")]
        [InverseProperty("StudentEnrolleds")]
        public virtual Student Student { get; set; } = null!;
        [ForeignKey("StudyTypeId")]
        [InverseProperty("StudentEnrolleds")]
        public virtual MonStudyType StudyType { get; set; } = null!;
    }
}
