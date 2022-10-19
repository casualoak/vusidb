using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    public partial class Teacher
    {
        public Teacher()
        {
            Documents = new HashSet<Document>();
            TeacherLectures = new HashSet<TeacherLecture>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("titleAndName")]
        [StringLength(255)]
        public string TitleAndName { get; set; } = null!;
        [Column("pin")]
        [StringLength(255)]
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
        [Column("countryId")]
        public int CountryId { get; set; }
        [Column("occupId")]
        public int OccupId { get; set; }
        [Column("occupationContractNum")]
        public int OccupationContractNum { get; set; }
        [Column("contractTypeId")]
        public int ContractTypeId { get; set; }
        [Column("contractNotes")]
        public string ContractNotes { get; set; } = null!;
        [Column("teacherStatus")]
        public int TeacherStatus { get; set; }
        [Column("requiredHoursNorm")]
        public int RequiredHoursNorm { get; set; }
        [Column("realHoursNorm")]
        public int RealHoursNorm { get; set; }
        [Column("scDegreeId")]
        public int ScDegreeId { get; set; }
        [Column("scAreaId")]
        public int ScAreaId { get; set; }
        [Column("acadRankId")]
        public int AcadRankId { get; set; }
        [Column("qualificationNotes")]
        public string QualificationNotes { get; set; } = null!;
        [Column("photoName")]
        public string? PhotoName { get; set; }
        [Column("oLDID")]
        public string? OLdid { get; set; }
        [Column("userid")]
        [StringLength(450)]
        public string? Userid { get; set; }
        [Column("birthDate", TypeName = "date")]
        public DateTime? BirthDate { get; set; }
        [Column("phone")]
        [StringLength(20)]
        public string? Phone { get; set; }
        [Column("email")]
        [StringLength(60)]
        public string? Email { get; set; }

        [ForeignKey("Userid")]
        [InverseProperty("Teachers")]
        public virtual AppUser? User { get; set; }
        [InverseProperty("TeacherNavigation")]
        public virtual ICollection<Document> Documents { get; set; }
        [InverseProperty("Teacher")]
        public virtual ICollection<TeacherLecture> TeacherLectures { get; set; }
    }
}
