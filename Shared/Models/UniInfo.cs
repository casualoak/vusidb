using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Table("UniInfo")]
    public partial class UniInfo
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("academicYear")]
        [StringLength(255)]
        public string? AcademicYear { get; set; }
        [Column("semester")]
        [StringLength(255)]
        public string? Semester { get; set; }
        [Column("code")]
        [StringLength(255)]
        public string? Code { get; set; }
        [Column("bulstat")]
        [StringLength(255)]
        public string? Bulstat { get; set; }
        [Column("establishedYear")]
        [StringLength(255)]
        public string? EstablishedYear { get; set; }
        [Column("fullName")]
        [StringLength(255)]
        public string? FullName { get; set; }
        [Column("shortName")]
        [StringLength(255)]
        public string? ShortName { get; set; }
        [Column("basicSchoolTypeId")]
        public int BasicSchoolTypeId { get; set; }
        [Column("schoolTypeId")]
        public int SchoolTypeId { get; set; }
        [Column("budgetFromId")]
        public int BudgetFromId { get; set; }
        [Column("postCode")]
        [StringLength(255)]
        public string? PostCode { get; set; }
        [Column("city")]
        [StringLength(255)]
        public string City { get; set; } = null!;
        [Column("address")]
        public string? Address { get; set; }
        [Column("email")]
        [StringLength(255)]
        public string? Email { get; set; }
        [Column("website")]
        [StringLength(255)]
        public string? Website { get; set; }
        [Column("phone1")]
        [StringLength(255)]
        public string? Phone1 { get; set; }
        [Column("phone2")]
        [StringLength(255)]
        public string? Phone2 { get; set; }
        [Column("phone3")]
        [StringLength(255)]
        public string? Phone3 { get; set; }
        [Column("phone4")]
        [StringLength(255)]
        public string? Phone4 { get; set; }
        [Column("phone5")]
        [StringLength(255)]
        public string? Phone5 { get; set; }
        [Column("fax")]
        [StringLength(255)]
        public string? Fax { get; set; }
        [Column("saliro_back_sync_data_version", TypeName = "datetime")]
        public DateTime SaliroBackSyncDataVersion { get; set; }
    }
}
