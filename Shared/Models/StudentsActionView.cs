using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Keyless]
    public partial class StudentsActionView
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("pin")]
        [StringLength(50)]
        public string Pin { get; set; } = null!;
        [Column("pinType")]
        public int PinType { get; set; }
        [Column("firstName")]
        [StringLength(255)]
        public string FirstName { get; set; } = null!;
        [Column("middleName")]
        [StringLength(255)]
        public string? MiddleName { get; set; }
        [Column("lastName")]
        [StringLength(255)]
        public string LastName { get; set; } = null!;
        [Column("gender")]
        public int Gender { get; set; }
        [Column("actionName")]
        [StringLength(255)]
        public string ActionName { get; set; } = null!;
        [Column("statusId")]
        public int StatusId { get; set; }
    }
}
