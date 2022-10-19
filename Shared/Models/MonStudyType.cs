using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Table("MonStudyType")]
    public partial class MonStudyType
    {
        public MonStudyType()
        {
            StudentEnrolleds = new HashSet<StudentEnrolled>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("studyTypeID")]
        public int StudyTypeId { get; set; }
        [Column("studyTypeName")]
        [StringLength(255)]
        public string StudyTypeName { get; set; } = null!;

        [InverseProperty("StudyType")]
        public virtual ICollection<StudentEnrolled> StudentEnrolleds { get; set; }
    }
}
