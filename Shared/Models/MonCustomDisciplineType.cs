using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Table("MonCustomDisciplineType")]
    public partial class MonCustomDisciplineType
    {
        public MonCustomDisciplineType()
        {
            PlanDisciplines = new HashSet<PlanDiscipline>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("disciplineTypeName")]
        [StringLength(255)]
        public string DisciplineTypeName { get; set; } = null!;

        [InverseProperty("Type")]
        public virtual ICollection<PlanDiscipline> PlanDisciplines { get; set; }
    }
}
