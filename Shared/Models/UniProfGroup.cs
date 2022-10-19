using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Table("UniProfGroup")]
    public partial class UniProfGroup
    {
        public UniProfGroup()
        {
            UniInfoMobilnosts = new HashSet<UniInfoMobilnost>();
            UniInfoStipendiis = new HashSet<UniInfoStipendii>();
            UniSpecialities = new HashSet<UniSpeciality>();
        }

        [Key]
        [Column("profGroupId")]
        public int ProfGroupId { get; set; }
        [Column("isAccredited")]
        public int IsAccredited { get; set; }
        [Column("oLDID")]
        [StringLength(255)]
        public string? OLdid { get; set; }
        [Column("accreditedFrom", TypeName = "date")]
        public DateTime? AccreditedFrom { get; set; }
        [Column("accreditedTo", TypeName = "date")]
        public DateTime? AccreditedTo { get; set; }

        [InverseProperty("ProfGroup")]
        public virtual ICollection<UniInfoMobilnost> UniInfoMobilnosts { get; set; }
        [InverseProperty("ProfGroup")]
        public virtual ICollection<UniInfoStipendii> UniInfoStipendiis { get; set; }
        [InverseProperty("ProfGroup")]
        public virtual ICollection<UniSpeciality> UniSpecialities { get; set; }
    }
}
