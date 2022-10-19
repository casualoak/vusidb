using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Table("MonOksExtendedInfo")]
    public partial class MonOksExtendedInfo
    {
        public MonOksExtendedInfo()
        {
            Students = new HashSet<Student>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("oksExtendedID")]
        public int OksExtendedId { get; set; }
        [Column("oksExtendedName")]
        [StringLength(255)]
        public string? OksExtendedName { get; set; }

        [InverseProperty("EnrollOksExtendedInfo")]
        public virtual ICollection<Student> Students { get; set; }
    }
}
