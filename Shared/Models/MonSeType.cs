using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Table("MonSeType")]
    public partial class MonSeType
    {
        public MonSeType()
        {
            StudentsStudyInfos = new HashSet<StudentsStudyInfo>();
        }

        [Column("sETypeID")]
        public int SEtypeId { get; set; }
        [Column("sETypeName")]
        [StringLength(255)]
        public string SEtypeName { get; set; } = null!;
        [Column("requireEducationalEstablishment")]
        public short RequireEducationalEstablishment { get; set; }
        [Column("requireProfGroup")]
        public short RequireProfGroup { get; set; }
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [InverseProperty("PrevStudyType")]
        public virtual ICollection<StudentsStudyInfo> StudentsStudyInfos { get; set; }
    }
}
