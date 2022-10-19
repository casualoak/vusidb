using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Keyless]
    public partial class UniSpecialityView
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("oksId")]
        public int OksId { get; set; }
        [Column("oksLevel")]
        [StringLength(255)]
        public string OksLevel { get; set; } = null!;
        [Column("specialityId")]
        public int SpecialityId { get; set; }
        [Column("profGroup")]
        [StringLength(255)]
        public string? ProfGroup { get; set; }
        [Column("speciality")]
        [StringLength(255)]
        public string? Speciality { get; set; }
        [Column("abbreviation")]
        public string? Abbreviation { get; set; }
        [Column("edFormId")]
        public int EdFormId { get; set; }
        [Column("edForm")]
        [StringLength(255)]
        public string? EdForm { get; set; }
        [Column("edLevelEx")]
        [StringLength(255)]
        public string? EdLevelEx { get; set; }
    }
}
