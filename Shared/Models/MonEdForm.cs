using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Table("MonEdForm")]
    public partial class MonEdForm
    {
        public MonEdForm()
        {
            TeacherLectures = new HashSet<TeacherLecture>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("edFormID")]
        public int EdFormId { get; set; }
        [Column("edFormName")]
        [StringLength(255)]
        public string? EdFormName { get; set; }

        [InverseProperty("LecturingEdForm")]
        public virtual ICollection<TeacherLecture> TeacherLectures { get; set; }
    }
}
