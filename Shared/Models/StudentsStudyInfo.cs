using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Table("StudentsStudyInfo")]
    public partial class StudentsStudyInfo
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("studentId")]
        public int StudentId { get; set; }
        [Column("prevStudyTypeId")]
        public int PrevStudyTypeId { get; set; }
        [Column("prevStudyFinishYear")]
        [StringLength(50)]
        public string? PrevStudyFinishYear { get; set; }
        [Column("prevStudySchoolName")]
        [StringLength(255)]
        public string? PrevStudySchoolName { get; set; }
        [Column("prevStudyProfGroupId")]
        public int? PrevStudyProfGroupId { get; set; }
        [Column("prevStudySpeciality")]
        [StringLength(255)]
        public string? PrevStudySpeciality { get; set; }
        [Column("prevStudyCountryId")]
        public int PrevStudyCountryId { get; set; }
        [Column("prevStudyDistrict")]
        [StringLength(255)]
        public string? PrevStudyDistrict { get; set; }
        [Column("prevStudyMunicipality")]
        [StringLength(255)]
        public string? PrevStudyMunicipality { get; set; }
        [Column("prevStudyLocationId")]
        public int? PrevStudyLocationId { get; set; }
        [Column("prevStudyDiplomSer")]
        [StringLength(50)]
        public string? PrevStudyDiplomSer { get; set; }
        [Column("prevStudyDiplomNum")]
        [StringLength(50)]
        public string? PrevStudyDiplomNum { get; set; }
        [Column("prevStudyDiplomRN")]
        [StringLength(50)]
        public string? PrevStudyDiplomRn { get; set; }
        [Column("prevStudyDiplomDate", TypeName = "date")]
        public DateTime? PrevStudyDiplomDate { get; set; }
        [Column("prevStudyScore")]
        [StringLength(50)]
        public string? PrevStudyScore { get; set; }
        [Column("prevStudyUniversityId")]
        public int? PrevStudyUniversityId { get; set; }
        [Column("created")]
        [Precision(0)]
        public DateTime Created { get; set; }

        [ForeignKey("PrevStudyCountryId")]
        [InverseProperty("StudentsStudyInfos")]
        public virtual MonCountryCode PrevStudyCountry { get; set; } = null!;
        [ForeignKey("PrevStudyTypeId")]
        [InverseProperty("StudentsStudyInfos")]
        public virtual MonSeType PrevStudyType { get; set; } = null!;
        [ForeignKey("PrevStudyUniversityId")]
        [InverseProperty("StudentsStudyInfos")]
        public virtual MonUniversity? PrevStudyUniversity { get; set; }
        [ForeignKey("StudentId")]
        [InverseProperty("StudentsStudyInfos")]
        public virtual Student Student { get; set; } = null!;
    }
}
