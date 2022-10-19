using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using VusiOnline.Shared.Models;

namespace VusiOnline.Infrastructure.Contexts
{
    public partial class VusiV1Context : DbContext
    {
        public VusiV1Context()
        {
        }

        public VusiV1Context(DbContextOptions<VusiV1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AuditTrail> AuditTrails { get; set; } = null!;
        public virtual DbSet<ChatHistory> ChatHistories { get; set; } = null!;
        public virtual DbSet<Document> Documents { get; set; } = null!;
        public virtual DbSet<DocumentExtendedAttribute> DocumentExtendedAttributes { get; set; } = null!;
        public virtual DbSet<DocumentType> DocumentTypes { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Log> Logs { get; set; } = null!;
        public virtual DbSet<MonAcadrankCode> MonAcadrankCodes { get; set; } = null!;
        public virtual DbSet<MonBasicSchoolType> MonBasicSchoolTypes { get; set; } = null!;
        public virtual DbSet<MonBudgetFrom> MonBudgetFroms { get; set; } = null!;
        public virtual DbSet<MonContractType> MonContractTypes { get; set; } = null!;
        public virtual DbSet<MonCountryCode> MonCountryCodes { get; set; } = null!;
        public virtual DbSet<MonCustomDisciplineType> MonCustomDisciplineTypes { get; set; } = null!;
        public virtual DbSet<MonEdForm> MonEdForms { get; set; } = null!;
        public virtual DbSet<MonEdPeriod> MonEdPeriods { get; set; } = null!;
        public virtual DbSet<MonEkatte> MonEkattes { get; set; } = null!;
        public virtual DbSet<MonNsiCode> MonNsiCodes { get; set; } = null!;
        public virtual DbSet<MonOccupationCode> MonOccupationCodes { get; set; } = null!;
        public virtual DbSet<MonOksExtendedInfo> MonOksExtendedInfos { get; set; } = null!;
        public virtual DbSet<MonOksSpecialityType> MonOksSpecialityTypes { get; set; } = null!;
        public virtual DbSet<MonProfGroup> MonProfGroups { get; set; } = null!;
        public virtual DbSet<MonReasonsForAcc> MonReasonsForAccs { get; set; } = null!;
        public virtual DbSet<MonScareaCode> MonScareaCodes { get; set; } = null!;
        public virtual DbSet<MonScdegreeCode> MonScdegreeCodes { get; set; } = null!;
        public virtual DbSet<MonSchoolTypeZnp> MonSchoolTypeZnps { get; set; } = null!;
        public virtual DbSet<MonSeType> MonSeTypes { get; set; } = null!;
        public virtual DbSet<MonSpeciality> MonSpecialities { get; set; } = null!;
        public virtual DbSet<MonStatusAction> MonStatusActions { get; set; } = null!;
        public virtual DbSet<MonStudyType> MonStudyTypes { get; set; } = null!;
        public virtual DbSet<MonUniversity> MonUniversities { get; set; } = null!;
        public virtual DbSet<Plan> Plans { get; set; } = null!;
        public virtual DbSet<PlanDiscipline> PlanDisciplines { get; set; } = null!;
        public virtual DbSet<PlanDisciplineTeacherLink> PlanDisciplineTeacherLinks { get; set; } = null!;
        public virtual DbSet<PlanDisciplinesDelete> PlanDisciplinesDeletes { get; set; } = null!;
        public virtual DbSet<PlanDisciplinesSpecialityView> PlanDisciplinesSpecialityViews { get; set; } = null!;
        public virtual DbSet<PlansDelete> PlansDeletes { get; set; } = null!;
        public virtual DbSet<Protocol> Protocols { get; set; } = null!;
        public virtual DbSet<ProtocolDisciplinePlansView> ProtocolDisciplinePlansViews { get; set; } = null!;
        public virtual DbSet<ProtocolStudent> ProtocolStudents { get; set; } = null!;
        public virtual DbSet<ProtocolStudentsDelete> ProtocolStudentsDeletes { get; set; } = null!;
        public virtual DbSet<ProtocolsDelete> ProtocolsDeletes { get; set; } = null!;
        public virtual DbSet<SchedeulerViewAllView> SchedeulerViewAllViews { get; set; } = null!;
        public virtual DbSet<SchedulerTmp> SchedulerTmps { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<StudentEnrollInfoView> StudentEnrollInfoViews { get; set; } = null!;
        public virtual DbSet<StudentEnrolled> StudentEnrolleds { get; set; } = null!;
        public virtual DbSet<StudentsActionView> StudentsActionViews { get; set; } = null!;
        public virtual DbSet<StudentsInfoSpecialityView> StudentsInfoSpecialityViews { get; set; } = null!;
        public virtual DbSet<StudentsStatusSpecialityGroupView> StudentsStatusSpecialityGroupViews { get; set; } = null!;
        public virtual DbSet<StudentsStudyInfo> StudentsStudyInfos { get; set; } = null!;
        public virtual DbSet<StudentsView> StudentsViews { get; set; } = null!;
        public virtual DbSet<StudentsViewMore> StudentsViewMores { get; set; } = null!;
        public virtual DbSet<Teacher> Teachers { get; set; } = null!;
        public virtual DbSet<TeacherDisciplinesView> TeacherDisciplinesViews { get; set; } = null!;
        public virtual DbSet<TeacherLecture> TeacherLectures { get; set; } = null!;
        public virtual DbSet<UniCourse> UniCourses { get; set; } = null!;
        public virtual DbSet<UniDiscipline> UniDisciplines { get; set; } = null!;
        public virtual DbSet<UniInfo> UniInfos { get; set; } = null!;
        public virtual DbSet<UniInfoDatabase> UniInfoDatabases { get; set; } = null!;
        public virtual DbSet<UniInfoDatabasesCode> UniInfoDatabasesCodes { get; set; } = null!;
        public virtual DbSet<UniInfoFinance> UniInfoFinances { get; set; } = null!;
        public virtual DbSet<UniInfoMobilnost> UniInfoMobilnosts { get; set; } = null!;
        public virtual DbSet<UniInfoStipendii> UniInfoStipendiis { get; set; } = null!;
        public virtual DbSet<UniProfGroup> UniProfGroups { get; set; } = null!;
        public virtual DbSet<UniSpeciality> UniSpecialities { get; set; } = null!;
        public virtual DbSet<UniSpecialityView> UniSpecialityViews { get; set; } = null!;
        public virtual DbSet<AppUser> Users { get; set; } = null!;
        public virtual DbSet<UserClaim> UserClaims { get; set; } = null!;
        public virtual DbSet<UserLogin> UserLogins { get; set; } = null!;
        public virtual DbSet<UserToken> UserTokens { get; set; } = null!;
        public virtual DbSet<AppRole> Roles { get; set; } = null!;
        public virtual DbSet<AppRoleClaim> RoleClaims { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=127.0.0.1;Initial Catalog=VusiV1;User ID=sa;Password=qwerty1234!;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Cyrillic_General_CI_AS");

            modelBuilder.Entity<Document>(entity =>
            {
                entity.HasOne(d => d.TeacherNavigation)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.Teacher)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Documents_Teachers");
            });

            modelBuilder.Entity<MonBasicSchoolType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<MonSpeciality>(entity =>
            {
                entity.HasOne(d => d.OksSpecialityType)
                    .WithMany(p => p.MonSpecialities)
                    .HasForeignKey(d => d.OksSpecialityTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("kia_mon_speciality_ibfk_1");
            });

            modelBuilder.Entity<Plan>(entity =>
            {
                entity.HasOne(d => d.CourseNavigation)
                    .WithMany(p => p.Plans)
                    .HasForeignKey(d => d.Course)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_kia_plans_kia_uni_course");

                entity.HasOne(d => d.Speciality)
                    .WithMany(p => p.Plans)
                    .HasForeignKey(d => d.SpecialityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_kia_plans_kia_uni_speciality");
            });

            modelBuilder.Entity<PlanDiscipline>(entity =>
            {
                entity.HasOne(d => d.Discipline)
                    .WithMany(p => p.PlanDisciplines)
                    .HasForeignKey(d => d.DisciplineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_kia_plan_disciplines_kia_uni_discipline");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.PlanDisciplines)
                    .HasForeignKey(d => d.PlanId)
                    .HasConstraintName("FK_kia_plan_disciplines_kia_plans");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.PlanDisciplines)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_kia_plan_disciplines_kia_mon_custom_discipline_type");
            });

            modelBuilder.Entity<PlanDisciplinesDelete>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<PlanDisciplinesSpecialityView>(entity =>
            {
                entity.ToView("PlanDisciplinesSpecialityView");
            });

            modelBuilder.Entity<PlansDelete>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Protocol>(entity =>
            {
                entity.HasOne(d => d.Discipline)
                    .WithMany(p => p.Protocols)
                    .HasForeignKey(d => d.DisciplineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_kia_protocols_kia_uni_discipline");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.Protocols)
                    .HasForeignKey(d => d.PlanId)
                    .HasConstraintName("kia_protocols_ibfk_1");

                entity.HasOne(d => d.Speciality)
                    .WithMany(p => p.Protocols)
                    .HasForeignKey(d => d.SpecialityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_kia_protocols_kia_uni_speciality");
            });

            modelBuilder.Entity<ProtocolDisciplinePlansView>(entity =>
            {
                entity.ToView("ProtocolDisciplinePlansView");
            });

            modelBuilder.Entity<ProtocolStudent>(entity =>
            {
                entity.HasOne(d => d.Protocol)
                    .WithMany(p => p.ProtocolStudents)
                    .HasForeignKey(d => d.ProtocolId)
                    .HasConstraintName("FK_kia_protocol_students_kia_protocols1");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.ProtocolStudents)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_kia_protocol_students_kia_students4");
            });

            modelBuilder.Entity<ProtocolStudentsDelete>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<ProtocolsDelete>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<AppRole>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.CreatedOn).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");
            });

            modelBuilder.Entity<AppRoleClaim>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");
            });

            modelBuilder.Entity<SchedeulerViewAllView>(entity =>
            {
                entity.ToView("SchedeulerViewAllView");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SchedulerTmp>(entity =>
            {
                entity.Property(e => e.EndTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StartTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Subject).HasDefaultValueSql("('Среща')");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasOne(d => d.EnrollOksExtendedInfo)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.EnrollOksExtendedInfoId)
                    .HasConstraintName("FK_kia_students_kia_students");

                entity.HasOne(d => d.EnrollOksSpecialtyType)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.EnrollOksSpecialtyTypeId)
                    .HasConstraintName("FK_kia_students_kia_mon_oks_speciality_type");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_kia_students_kia_mon_status_action");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("FK_students_users");
            });

            modelBuilder.Entity<StudentEnrollInfoView>(entity =>
            {
                entity.ToView("StudentEnrollInfoView");
            });

            modelBuilder.Entity<StudentEnrolled>(entity =>
            {
                entity.HasOne(d => d.Speciality)
                    .WithMany(p => p.StudentEnrolleds)
                    .HasForeignKey(d => d.SpecialityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_kia_student_enrolled_kia_uni_speciality");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentEnrolleds)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_kia_student_enrolled_kia_students");

                entity.HasOne(d => d.StudyType)
                    .WithMany(p => p.StudentEnrolleds)
                    .HasForeignKey(d => d.StudyTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_kia_student_enrolled_kia_mon_study_type");
            });

            modelBuilder.Entity<StudentsActionView>(entity =>
            {
                entity.ToView("StudentsActionView");
            });

            modelBuilder.Entity<StudentsInfoSpecialityView>(entity =>
            {
                entity.ToView("StudentsInfoSpecialityView");
            });

            modelBuilder.Entity<StudentsStatusSpecialityGroupView>(entity =>
            {
                entity.ToView("StudentsStatusSpecialityGroupView");
            });

            modelBuilder.Entity<StudentsStudyInfo>(entity =>
            {
                entity.HasOne(d => d.PrevStudyCountry)
                    .WithMany(p => p.StudentsStudyInfos)
                    .HasForeignKey(d => d.PrevStudyCountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("kia_students_study_info_ibfk_2");

                entity.HasOne(d => d.PrevStudyType)
                    .WithMany(p => p.StudentsStudyInfos)
                    .HasForeignKey(d => d.PrevStudyTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_kia_students_study_info_kia_mon_se_type");

                entity.HasOne(d => d.PrevStudyUniversity)
                    .WithMany(p => p.StudentsStudyInfos)
                    .HasForeignKey(d => d.PrevStudyUniversityId)
                    .HasConstraintName("FK_kia_students_study_info_kia_students_study_info");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentsStudyInfos)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_kia_students_study_info_kia_students");
            });

            modelBuilder.Entity<StudentsView>(entity =>
            {
                entity.ToView("StudentsView");
            });

            modelBuilder.Entity<StudentsViewMore>(entity =>
            {
                entity.ToView("StudentsViewMore");
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.Teachers)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("FK_teachers_users");
            });

            modelBuilder.Entity<TeacherDisciplinesView>(entity =>
            {
                entity.ToView("TeacherDisciplinesView");
            });

            modelBuilder.Entity<TeacherLecture>(entity =>
            {
                entity.HasOne(d => d.LecturingEdForm)
                    .WithMany(p => p.TeacherLectures)
                    .HasForeignKey(d => d.LecturingEdFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_kia_teacher_lecture_kia_mon_ed_form33");

                entity.HasOne(d => d.LecturingSpeciality)
                    .WithMany(p => p.TeacherLectures)
                    .HasForeignKey(d => d.LecturingSpecialityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeacherLecture_MonSpeciality");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.TeacherLectures)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_kia_teacher_lecture_kia_teachers");
            });

            modelBuilder.Entity<UniInfoMobilnost>(entity =>
            {
                entity.HasOne(d => d.ProfGroup)
                    .WithMany(p => p.UniInfoMobilnosts)
                    .HasForeignKey(d => d.ProfGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_kia_uni_info_mobilnost_kia_uni_prof_group");
            });

            modelBuilder.Entity<UniInfoStipendii>(entity =>
            {
                entity.HasOne(d => d.ProfGroup)
                    .WithMany(p => p.UniInfoStipendiis)
                    .HasForeignKey(d => d.ProfGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_kia_uni_info_stipendii_kia_uni_prof_group");
            });

            modelBuilder.Entity<UniProfGroup>(entity =>
            {
                entity.HasKey(e => e.ProfGroupId)
                    .HasName("PK_kia_uni_prof_group");

                entity.Property(e => e.ProfGroupId).ValueGeneratedNever();
            });

            modelBuilder.Entity<UniSpeciality>(entity =>
            {
                entity.HasOne(d => d.NsiCode)
                    .WithMany(p => p.UniSpecialities)
                    .HasForeignKey(d => d.NsiCodeId)
                    .HasConstraintName("kia_uni_speciality_ibfk_3");

                entity.HasOne(d => d.Oks)
                    .WithMany(p => p.UniSpecialities)
                    .HasForeignKey(d => d.OksId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("kia_uni_speciality_ibfk_2");

                entity.HasOne(d => d.ProfGroup)
                    .WithMany(p => p.UniSpecialities)
                    .HasForeignKey(d => d.ProfGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_kia_uni_speciality_kia_uni_prof_group");

                entity.HasOne(d => d.Speciality)
                    .WithMany(p => p.UniSpecialities)
                    .HasForeignKey(d => d.SpecialityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("kia_uni_speciality_ibfk_4");
            });

            modelBuilder.Entity<UniSpecialityView>(entity =>
            {
                entity.ToView("UniSpecialityView");
            });

            modelBuilder.Entity<AppUser>(entity =>
            {
                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.HasMany(d => d.Roles)
                    .WithMany(p => p.Users)
                    .UsingEntity<Dictionary<string, object>>(
                        "UserRole",
                        l => l.HasOne<AppRole>().WithMany().HasForeignKey("RoleId"),
                        r => r.HasOne<AppUser>().WithMany().HasForeignKey("UserId"),
                        j =>
                        {
                            j.HasKey("UserId", "RoleId");

                            j.ToTable("UserRoles", "Identity");

                            j.HasIndex(new[] { "RoleId" }, "IX_UserRoles_RoleId");
                        });
            });

            modelBuilder.Entity<UserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });
            });

            modelBuilder.Entity<UserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });
            });

            modelBuilder.HasSequence("CountBy1").StartsAt(200);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
