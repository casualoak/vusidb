using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Table("MonBudgetFrom")]
    public partial class MonBudgetFrom
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("budgetFromID")]
        public int BudgetFromId { get; set; }
        [Column("budgetFromName")]
        [StringLength(255)]
        public string? BudgetFromName { get; set; }
    }
}
