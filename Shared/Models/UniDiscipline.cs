using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Table("UniDiscipline")]
    public partial class UniDiscipline
    {
        public UniDiscipline()
        {
            PlanDisciplines = new HashSet<PlanDiscipline>();
            Protocols = new HashSet<Protocol>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; } = null!;

        [InverseProperty("Discipline")]
        public virtual ICollection<PlanDiscipline> PlanDisciplines { get; set; }
        [InverseProperty("Discipline")]
        public virtual ICollection<Protocol> Protocols { get; set; }
    }
}
