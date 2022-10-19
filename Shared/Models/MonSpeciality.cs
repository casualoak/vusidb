using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Table("MonSpeciality")]
    public partial class MonSpeciality
    {
        public MonSpeciality()
        {
            TeacherLectures = new HashSet<TeacherLecture>();
            UniSpecialities = new HashSet<UniSpeciality>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("code")]
        public int Code { get; set; }
        [Column("areaVO")]
        [StringLength(255)]
        public string? AreaVo { get; set; }
        [Column("profGroupName")]
        [StringLength(255)]
        public string? ProfGroupName { get; set; }
        [Column("specialityName")]
        [StringLength(255)]
        public string? SpecialityName { get; set; }
        [Column("oksSpecialityTypeID")]
        public int OksSpecialityTypeId { get; set; }
        [Column("afterSpecialityTypeID")]
        [StringLength(255)]
        public string? AfterSpecialityTypeId { get; set; }
        [Column("allowExport")]
        public short AllowExport { get; set; }

        [ForeignKey("OksSpecialityTypeId")]
        [InverseProperty("MonSpecialities")]
        public virtual MonOksSpecialityType OksSpecialityType { get; set; } = null!;
        [InverseProperty("LecturingSpeciality")]
        public virtual ICollection<TeacherLecture> TeacherLectures { get; set; }
        [InverseProperty("Speciality")]
        public virtual ICollection<UniSpeciality> UniSpecialities { get; set; }
    }
}
