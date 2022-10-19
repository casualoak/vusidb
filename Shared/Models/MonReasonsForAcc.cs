using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Table("MonReasonsForAcc")]
    public partial class MonReasonsForAcc
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("reasonsForAccID")]
        public int ReasonsForAccId { get; set; }
        [Column("reasonsForAccName")]
        [StringLength(255)]
        public string ReasonsForAccName { get; set; } = null!;
    }
}
