using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Keyless]
    public partial class StudentsViewMore
    {
        [Column("id_students")]
        public int IdStudents { get; set; }
        [Column("pin")]
        [StringLength(50)]
        public string Pin { get; set; } = null!;
        [Column("pinType")]
        public int PinType { get; set; }
        [Column("firstName")]
        [StringLength(255)]
        public string FirstName { get; set; } = null!;
        [Column("middleName")]
        [StringLength(255)]
        public string? MiddleName { get; set; }
        [Column("lastName")]
        [StringLength(255)]
        public string LastName { get; set; } = null!;
        [Column("statusId")]
        public int StatusId { get; set; }
        [Column("personalInfoEmail")]
        public string? PersonalInfoEmail { get; set; }
        [Column("last_student_enrolled")]
        public int? LastStudentEnrolled { get; set; }
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
        [Column("monId")]
        public int MonId { get; set; }
        [Column("specialityName")]
        [StringLength(255)]
        public string? SpecialityName { get; set; }
        [Column("edFormName")]
        [StringLength(255)]
        public string? EdFormName { get; set; }
        [Column("actionName")]
        [StringLength(255)]
        public string ActionName { get; set; } = null!;
        [Column("actionID")]
        public int ActionId { get; set; }
    }
}
