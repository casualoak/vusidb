using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Table("MonProfGroup")]
    public partial class MonProfGroup
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("profGroupID")]
        public int ProfGroupId { get; set; }
        [Column("profGroupName")]
        [StringLength(255)]
        public string? ProfGroupName { get; set; }
        [Column("profGroupArea")]
        [StringLength(255)]
        public string? ProfGroupArea { get; set; }
    }
}
