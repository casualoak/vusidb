using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Keyless]
    public partial class StudentsInfoSpecialityView
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
        [Column("_enrollCourseName")]
        [StringLength(100)]
        public string? EnrollCourseName { get; set; }
        [Column("enrollCourseExport")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EnrollCourseExport { get; set; }
        [Column("prevStudyTypeId")]
        public int? PrevStudyTypeId { get; set; }
        [Column("prevStudyFinishYear")]
        [StringLength(50)]
        public string? PrevStudyFinishYear { get; set; }
        [Column("prevStudySchoolName")]
        [StringLength(255)]
        public string? PrevStudySchoolName { get; set; }
        [Column("prevStudySpeciality")]
        [StringLength(255)]
        public string? PrevStudySpeciality { get; set; }
        [Column("prevStudyCountryId")]
        public int? PrevStudyCountryId { get; set; }
        [Column("prevStudyDistrict")]
        [StringLength(255)]
        public string? PrevStudyDistrict { get; set; }
        [Column("prevStudyMunicipality")]
        [StringLength(255)]
        public string? PrevStudyMunicipality { get; set; }
        [Column("prevStudyLocationId")]
        public int? PrevStudyLocationId { get; set; }
        [Column("prevStudyDiplomSer")]
        [StringLength(50)]
        public string? PrevStudyDiplomSer { get; set; }
        [Column("prevStudyDiplomNum")]
        [StringLength(50)]
        public string? PrevStudyDiplomNum { get; set; }
        [Column("prevStudyDiplomRN")]
        [StringLength(50)]
        public string? PrevStudyDiplomRn { get; set; }
        [Column("prevStudyScore")]
        [StringLength(50)]
        public string? PrevStudyScore { get; set; }
        [Column("statusName")]
        [StringLength(255)]
        public string StatusName { get; set; } = null!;
        [Column("highSchoolCode")]
        public int? HighSchoolCode { get; set; }
        [Column("highSchoolName")]
        [StringLength(255)]
        public string? HighSchoolName { get; set; }
        [Column("prevStudyDiplomDate", TypeName = "date")]
        public DateTime? PrevStudyDiplomDate { get; set; }
        [Column("profGroupName")]
        [StringLength(255)]
        public string? ProfGroupName { get; set; }
        [Column("profGroupArea")]
        [StringLength(255)]
        public string? ProfGroupArea { get; set; }
        [Column("prevStudyProfGroupId")]
        public int? PrevStudyProfGroupId { get; set; }
        [Column("prevStudyProfGroupCode")]
        public int? PrevStudyProfGroupCode { get; set; }
        [Column("speciality_name")]
        public string? SpecialityName { get; set; }
        [Column("specialityId")]
        public int? SpecialityId { get; set; }
        [Column("specialityTypeName")]
        [StringLength(255)]
        public string? SpecialityTypeName { get; set; }
        [Column("_oksExtendedName")]
        [StringLength(255)]
        public string? OksExtendedName { get; set; }
        [Column("enrollYear")]
        [StringLength(50)]
        public string? EnrollYear { get; set; }
        [Column("admitYear")]
        [StringLength(50)]
        public string? AdmitYear { get; set; }
        [Column("enrollSpecialityId")]
        public int? EnrollSpecialityId { get; set; }
        [Column("enrollCourse")]
        public int? EnrollCourse { get; set; }
        [Column("enrollSpecialityNum")]
        public int? EnrollSpecialityNum { get; set; }
        [Column("enrollStudyTypeId")]
        public int? EnrollStudyTypeId { get; set; }
        [Column("enrollOrderNum")]
        [StringLength(255)]
        public string? EnrollOrderNum { get; set; }
        [Column("enrollOrderDate", TypeName = "date")]
        public DateTime? EnrollOrderDate { get; set; }
        [Column("enrollOrderEndDate", TypeName = "date")]
        public DateTime? EnrollOrderEndDate { get; set; }
        [Column("enrollScore")]
        [StringLength(50)]
        public string? EnrollScore { get; set; }
    }
}
