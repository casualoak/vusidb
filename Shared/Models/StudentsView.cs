using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Keyless]
    public partial class StudentsView
    {
        public int StudentId { get; set; }
        [StringLength(255)]
        public string FacultyNo { get; set; } = null!;
        [StringLength(50)]
        public string? Year { get; set; }
        public int? Course { get; set; }
        [Column("EGN")]
        [StringLength(50)]
        public string Egn { get; set; } = null!;
        [StringLength(767)]
        public string Name { get; set; } = null!;
        [StringLength(255)]
        public string State { get; set; } = null!;
        public int StateId { get; set; }
        [StringLength(255)]
        public string? EdForm { get; set; }
        [Column("specialityTypeID")]
        public int SpecialityTypeId { get; set; }
        [Column("specialityTypeName")]
        [StringLength(255)]
        public string SpecialityTypeName { get; set; } = null!;
        [StringLength(255)]
        public string? EdSpeciality { get; set; }
        public int Code { get; set; }
        public int Debtor { get; set; }
        public string? Email { get; set; }
    }
}
