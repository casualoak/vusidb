using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Table("UniSpeciality")]
    public partial class UniSpeciality
    {
        public UniSpeciality()
        {
            Plans = new HashSet<Plan>();
            Protocols = new HashSet<Protocol>();
            StudentEnrolleds = new HashSet<StudentEnrolled>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("profGroupId")]
        public int ProfGroupId { get; set; }
        [Column("oksId")]
        public int OksId { get; set; }
        [Column("specialityId")]
        public int SpecialityId { get; set; }
        [Column("abbreviation")]
        public string? Abbreviation { get; set; }
        [Column("edFormId")]
        public int EdFormId { get; set; }
        [Column("edPeriodId", TypeName = "decimal(10, 1)")]
        public decimal EdPeriodId { get; set; }
        [Column("isAccredited")]
        public int IsAccredited { get; set; }
        [Column("nsiCodeId")]
        public int? NsiCodeId { get; set; }
        [Column("oksExtendedId")]
        public int OksExtendedId { get; set; }
        [Column("isClosed")]
        public int IsClosed { get; set; }
        [Column("characteristic")]
        public string? Characteristic { get; set; }
        [Column("oLDID")]
        public string? OLdid { get; set; }
        [Column("accreditedFrom", TypeName = "date")]
        public DateTime? AccreditedFrom { get; set; }
        [Column("accreditedTo", TypeName = "date")]
        public DateTime? AccreditedTo { get; set; }
        [Column("teacher_lecture_id")]
        public int? TeacherLectureId { get; set; }

        [ForeignKey("NsiCodeId")]
        [InverseProperty("UniSpecialities")]
        public virtual MonNsiCode? NsiCode { get; set; }
        [ForeignKey("OksId")]
        [InverseProperty("UniSpecialities")]
        public virtual MonOksSpecialityType Oks { get; set; } = null!;
        [ForeignKey("ProfGroupId")]
        [InverseProperty("UniSpecialities")]
        public virtual UniProfGroup ProfGroup { get; set; } = null!;
        [ForeignKey("SpecialityId")]
        [InverseProperty("UniSpecialities")]
        public virtual MonSpeciality Speciality { get; set; } = null!;
        [InverseProperty("Speciality")]
        public virtual ICollection<Plan> Plans { get; set; }
        [InverseProperty("Speciality")]
        public virtual ICollection<Protocol> Protocols { get; set; }
        [InverseProperty("Speciality")]
        public virtual ICollection<StudentEnrolled> StudentEnrolleds { get; set; }
    }
}
