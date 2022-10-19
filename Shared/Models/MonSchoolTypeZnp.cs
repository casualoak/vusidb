using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Table("MonSchoolTypeZnp")]
    public partial class MonSchoolTypeZnp
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("schoolTypeID")]
        public int SchoolTypeId { get; set; }
        [Column("schoolTypeName")]
        [StringLength(255)]
        public string? SchoolTypeName { get; set; }
    }
}
