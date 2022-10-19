using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Table("UniCourse")]
    public partial class UniCourse
    {
        public UniCourse()
        {
            Plans = new HashSet<Plan>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        [StringLength(100)]
        public string Name { get; set; } = null!;
        [Column("courseExport")]
        [StringLength(10)]
        [Unicode(false)]
        public string? CourseExport { get; set; }

        [InverseProperty("CourseNavigation")]
        public virtual ICollection<Plan> Plans { get; set; }
    }
}
