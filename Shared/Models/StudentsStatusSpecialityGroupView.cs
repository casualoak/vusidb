using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Keyless]
    public partial class StudentsStatusSpecialityGroupView
    {
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
        [Column("gender")]
        public int Gender { get; set; }
        [Column("birthLocationId")]
        public int? BirthLocationId { get; set; }
        [Column("citizenshipId")]
        public int CitizenshipId { get; set; }
        [Column("liveCountryId")]
        public int LiveCountryId { get; set; }
        [Column("liveLocationId")]
        public int? LiveLocationId { get; set; }
        [Column("birthDate")]
        [StringLength(30)]
        [Unicode(false)]
        public string? BirthDate { get; set; }
        [Column("prevStudyTypeId")]
        public int? PrevStudyTypeId { get; set; }
        [Column("prevStudySpeciality")]
        [StringLength(255)]
        public string? PrevStudySpeciality { get; set; }
        [Column("profil")]
        [StringLength(1)]
        [Unicode(false)]
        public string Profil { get; set; } = null!;
    }
}
