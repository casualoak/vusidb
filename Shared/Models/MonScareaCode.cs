using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Table("MonScareaCode")]
    public partial class MonScareaCode
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("scAreaID")]
        public int ScAreaId { get; set; }
        [Column("scAreaName")]
        [StringLength(255)]
        public string? ScAreaName { get; set; }
    }
}
