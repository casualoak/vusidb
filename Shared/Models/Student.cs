using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Index("Fn", Name = "Ind_students_fn")]
    public partial class Student
    {
        public Student()
        {
            ProtocolStudents = new HashSet<ProtocolStudent>();
            StudentEnrolleds = new HashSet<StudentEnrolled>();
            StudentsStudyInfos = new HashSet<StudentsStudyInfo>();
        }

        [Key]
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
        [Column("birthCountryId")]
        public int BirthCountryId { get; set; }
        [Column("birthDistrict")]
        [StringLength(255)]
        public string? BirthDistrict { get; set; }
        [Column("birthMunicipality")]
        [StringLength(255)]
        public string? BirthMunicipality { get; set; }
        [Column("birthLocationId")]
        public int? BirthLocationId { get; set; }
        [Column("citizenshipId")]
        public int CitizenshipId { get; set; }
        [Column("liveCountryId")]
        public int LiveCountryId { get; set; }
        [Column("liveDistrict")]
        [StringLength(255)]
        public string? LiveDistrict { get; set; }
        [Column("liveMunicipality")]
        [StringLength(255)]
        public string? LiveMunicipality { get; set; }
        [Column("liveLocationId")]
        public int? LiveLocationId { get; set; }
        [Column("fn")]
        [StringLength(255)]
        public string Fn { get; set; } = null!;
        [Column("reasonsForAccId")]
        public int ReasonsForAccId { get; set; }
        [Column("stipendy")]
        public int Stipendy { get; set; }
        [Column("hostel")]
        public int Hostel { get; set; }
        [Column("statusId")]
        public int StatusId { get; set; }
        [Column("statusNote")]
        public string? StatusNote { get; set; }
        [Column("universityId")]
        public int? UniversityId { get; set; }
        [Column("restBase")]
        public int RestBase { get; set; }
        [Column("internacionalProgram")]
        public int InternacionalProgram { get; set; }
        [Column("photoName")]
        public string? PhotoName { get; set; }
        [Column("enrollOksSpecialtyTypeId")]
        public int? EnrollOksSpecialtyTypeId { get; set; }
        [Column("enrollOksExtendedInfoId")]
        public int? EnrollOksExtendedInfoId { get; set; }
        [Column("oLDID")]
        public string? OLdid { get; set; }
        [Column("personalInfoStreet")]
        public string? PersonalInfoStreet { get; set; }
        [Column("personalInfoTown")]
        public string? PersonalInfoTown { get; set; }
        [Column("personalInfoPhones")]
        public string? PersonalInfoPhones { get; set; }
        [Column("personalInfoEmail")]
        public string? PersonalInfoEmail { get; set; }
        [Column("debtor")]
        public int Debtor { get; set; }
        [Column("userid")]
        [StringLength(450)]
        public string? Userid { get; set; }
        [Column("birthDate", TypeName = "date")]
        public DateTime? BirthDate { get; set; }
        [Column("statusDate", TypeName = "date")]
        public DateTime? StatusDate { get; set; }

        [ForeignKey("EnrollOksExtendedInfoId")]
        [InverseProperty("Students")]
        public virtual MonOksExtendedInfo? EnrollOksExtendedInfo { get; set; }
        [ForeignKey("EnrollOksSpecialtyTypeId")]
        [InverseProperty("Students")]
        public virtual MonOksSpecialityType? EnrollOksSpecialtyType { get; set; }
        [ForeignKey("StatusId")]
        [InverseProperty("Students")]
        public virtual MonStatusAction Status { get; set; } = null!;
        [ForeignKey("Userid")]
        [InverseProperty("Students")]
        public virtual AppUser? User { get; set; }
        [InverseProperty("Student")]
        public virtual ICollection<ProtocolStudent> ProtocolStudents { get; set; }
        [InverseProperty("Student")]
        public virtual ICollection<StudentEnrolled> StudentEnrolleds { get; set; }
        [InverseProperty("Student")]
        public virtual ICollection<StudentsStudyInfo> StudentsStudyInfos { get; set; }
    }
}
