using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Table("MonOksSpecialityType")]
    public partial class MonOksSpecialityType
    {
        public MonOksSpecialityType()
        {
            MonSpecialities = new HashSet<MonSpeciality>();
            Students = new HashSet<Student>();
            UniSpecialities = new HashSet<UniSpeciality>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("specialityTypeID")]
        public int SpecialityTypeId { get; set; }
        [Column("specialityTypeName")]
        [StringLength(255)]
        public string SpecialityTypeName { get; set; } = null!;

        [InverseProperty("OksSpecialityType")]
        public virtual ICollection<MonSpeciality> MonSpecialities { get; set; }
        [InverseProperty("EnrollOksSpecialtyType")]
        public virtual ICollection<Student> Students { get; set; }
        [InverseProperty("Oks")]
        public virtual ICollection<UniSpeciality> UniSpecialities { get; set; }
    }
}
