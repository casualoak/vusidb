using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Table("MonBasicSchoolType")]
    public partial class MonBasicSchoolType
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("basicSchoolTypeID")]
        public int BasicSchoolTypeId { get; set; }
        [Column("basicSchoolTypeName")]
        [StringLength(255)]
        public string? BasicSchoolTypeName { get; set; }
    }
}
