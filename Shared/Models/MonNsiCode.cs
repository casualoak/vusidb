using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Table("MonNsiCode")]
    public partial class MonNsiCode
    {
        public MonNsiCode()
        {
            UniSpecialities = new HashSet<UniSpeciality>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("nSIID")]
        public int NSiid { get; set; }
        [Column("nSIName")]
        public string? NSiname { get; set; }

        [InverseProperty("NsiCode")]
        public virtual ICollection<UniSpeciality> UniSpecialities { get; set; }
    }
}
