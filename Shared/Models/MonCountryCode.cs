using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Table("MonCountryCode")]
    public partial class MonCountryCode
    {
        public MonCountryCode()
        {
            StudentsStudyInfos = new HashSet<StudentsStudyInfo>();
        }

        [Column("countryID")]
        public int CountryId { get; set; }
        [Column("countryName")]
        [StringLength(255)]
        public string CountryName { get; set; } = null!;
        [Column("vcISO_3166Code")]
        [StringLength(255)]
        public string VcIso3166code { get; set; } = null!;
        [Column("vcISO_A3")]
        [StringLength(255)]
        public string VcIsoA3 { get; set; } = null!;
        [Column("intISO_Number")]
        public int? IntIsoNumber { get; set; }
        [Column("intIsEUMember")]
        public int? IntIsEumember { get; set; }
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [InverseProperty("PrevStudyCountry")]
        public virtual ICollection<StudentsStudyInfo> StudentsStudyInfos { get; set; }
    }
}
