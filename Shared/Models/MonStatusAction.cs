using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Table("MonStatusAction")]
    public partial class MonStatusAction
    {
        public MonStatusAction()
        {
            Students = new HashSet<Student>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("actionID")]
        public int ActionId { get; set; }
        [Column("actionName")]
        [StringLength(255)]
        public string ActionName { get; set; } = null!;

        [InverseProperty("Status")]
        public virtual ICollection<Student> Students { get; set; }
    }
}
