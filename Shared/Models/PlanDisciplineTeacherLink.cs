using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Table("PlanDisciplineTeacherLink")]
    public partial class PlanDisciplineTeacherLink
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("id_plan_disciplines")]
        public int IdPlanDisciplines { get; set; }
        [Column("discipline")]
        public int Discipline { get; set; }
        [Column("id_teacher")]
        public int IdTeacher { get; set; }
        [Column("start_date", TypeName = "date")]
        public DateTime StartDate { get; set; }
        [Column("end_date", TypeName = "date")]
        public DateTime EndDate { get; set; }
    }
}
