using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Table("MonUniversity")]
    public partial class MonUniversity
    {
        public MonUniversity()
        {
            StudentsStudyInfos = new HashSet<StudentsStudyInfo>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("universityID")]
        public int UniversityId { get; set; }
        [Column("universityName")]
        [StringLength(255)]
        public string UniversityName { get; set; } = null!;

        [InverseProperty("PrevStudyUniversity")]
        public virtual ICollection<StudentsStudyInfo> StudentsStudyInfos { get; set; }
    }
}
