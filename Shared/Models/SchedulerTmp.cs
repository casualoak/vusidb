using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Table("scheduler_tmp")]
    public partial class SchedulerTmp
    {
        [Key]
        public int Id { get; set; }
        [StringLength(250)]
        public string Subject { get; set; } = null!;
        [StringLength(50)]
        public string? Location { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime StartTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime EndTime { get; set; }
        [StringLength(250)]
        public string? Description { get; set; }
        public bool? IsAllDay { get; set; }
        public bool? IsReadonly { get; set; }
        [StringLength(250)]
        public string? RecurrenceRule { get; set; }
        [StringLength(250)]
        public string? RecurrenceException { get; set; }
        [Column("RecurrenceID")]
        public int? RecurrenceId { get; set; }
        [Column("userid")]
        public int? Userid { get; set; }
        [Column("speciality_Id")]
        public int? SpecialityId { get; set; }
        [Column("discipline_id")]
        public int? DisciplineId { get; set; }
        [Column("plan_year")]
        public int? PlanYear { get; set; }
        [Column("course")]
        public int? Course { get; set; }
        [Column("edFormID")]
        public int? EdFormId { get; set; }
        [Column("semester")]
        public int? Semester { get; set; }
        [Column("specialityTypeID")]
        public int? SpecialityTypeId { get; set; }
        [Column("speciality_Id_text")]
        [StringLength(250)]
        public string? SpecialityIdText { get; set; }
        [Column("discipline_id_text")]
        [StringLength(250)]
        public string? DisciplineIdText { get; set; }
        [StringLength(15)]
        public string? CategoryColor { get; set; }
        [StringLength(25)]
        public string? StartTimezone { get; set; }
        [StringLength(25)]
        public string? EndTimezone { get; set; }
        public int? OwnerId { get; set; }
        [Column("group_id")]
        public int? GroupId { get; set; }
        [Column("teacher_id")]
        public int? TeacherId { get; set; }
        [Column("students_id")]
        public int? StudentsId { get; set; }
    }
}
