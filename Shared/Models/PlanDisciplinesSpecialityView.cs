using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Keyless]
    public partial class PlanDisciplinesSpecialityView
    {
        [Column("id_kia_plan_disciplines")]
        public int IdKiaPlanDisciplines { get; set; }
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
        [Column("id_kia_plans")]
        public int IdKiaPlans { get; set; }
        [Column("abbreviation")]
        public string Abbreviation { get; set; } = null!;
        [Column("specialityId")]
        public int SpecialityId { get; set; }
        [Column("year")]
        [StringLength(255)]
        public string Year { get; set; } = null!;
        [Column("course")]
        public int Course { get; set; }
        [Column("semester")]
        [StringLength(255)]
        public string Semester { get; set; } = null!;
        [Column("dateAcceptedByFS", TypeName = "date")]
        public DateTime DateAcceptedByFs { get; set; }
        [Column("dateAcceptedByAS", TypeName = "date")]
        public DateTime DateAcceptedByAs { get; set; }
        [Column("dateStart", TypeName = "date")]
        public DateTime DateStart { get; set; }
        [Column("dateEnd", TypeName = "date")]
        public DateTime DateEnd { get; set; }
        [Column("id_kia_uni_discipline")]
        public int IdKiaUniDiscipline { get; set; }
        [Column("name_kia_uni_discipline")]
        public string NameKiaUniDiscipline { get; set; } = null!;
        [Column("id_kia_mon_speciality")]
        public int IdKiaMonSpeciality { get; set; }
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
        [Column("id_kia_uni_speciality")]
        public int IdKiaUniSpeciality { get; set; }
        [Column("profGroupId")]
        public int ProfGroupId { get; set; }
        [Column("oksId")]
        public int OksId { get; set; }
        [Column("specialityId_speciality")]
        public int SpecialityIdSpeciality { get; set; }
        [Column("abbreviation_speciality")]
        public string? AbbreviationSpeciality { get; set; }
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
        [Column("accreditedFrom", TypeName = "date")]
        public DateTime? AccreditedFrom { get; set; }
        [Column("accreditedTo", TypeName = "date")]
        public DateTime? AccreditedTo { get; set; }
        [Column("teacherId")]
        public int? TeacherId { get; set; }
    }
}
