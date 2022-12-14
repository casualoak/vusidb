using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    public partial class Plan
    {
        public Plan()
        {
            PlanDisciplines = new HashSet<PlanDiscipline>();
            Protocols = new HashSet<Protocol>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
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
        [Column("oLDID")]
        [StringLength(255)]
        public string? OLdid { get; set; }
        [Column("dateAcceptedByFS", TypeName = "date")]
        public DateTime DateAcceptedByFs { get; set; }
        [Column("dateAcceptedByAS", TypeName = "date")]
        public DateTime DateAcceptedByAs { get; set; }
        [Column("dateStart", TypeName = "date")]
        public DateTime DateStart { get; set; }
        [Column("dateEnd", TypeName = "date")]
        public DateTime DateEnd { get; set; }

        [ForeignKey("Course")]
        [InverseProperty("Plans")]
        public virtual UniCourse CourseNavigation { get; set; } = null!;
        [ForeignKey("SpecialityId")]
        [InverseProperty("Plans")]
        public virtual UniSpeciality Speciality { get; set; } = null!;
        [InverseProperty("Plan")]
        public virtual ICollection<PlanDiscipline> PlanDisciplines { get; set; }
        [InverseProperty("Plan")]
        public virtual ICollection<Protocol> Protocols { get; set; }
    }
}
