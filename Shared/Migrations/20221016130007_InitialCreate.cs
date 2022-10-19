using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VusiDB.Shared.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Identity");

            migrationBuilder.CreateSequence(
                name: "CountBy1",
                startValue: 200L);

            migrationBuilder.CreateTable(
                name: "AuditTrails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TableName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OldValues = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewValues = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AffectedColumns = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: true),
                    PrimaryKey = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditTrails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    userpass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    addressStreetName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    addressStreetNumber = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    addressCity = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    addressPostCode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    landline = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    landlineInternal = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    mobileFirst = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    mobileSecond = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    fax = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    accessLevel = table.Column<short>(type: "smallint", nullable: false),
                    photoName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    userid = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    oldObj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    newObj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    adminId = table.Column<int>(type: "int", nullable: false),
                    dateIn = table.Column<DateTime>(type: "datetime2(0)", precision: 0, nullable: false),
                    operation = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    className = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MonAcadrankCode",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    acadRankID = table.Column<int>(type: "int", nullable: false),
                    acadRankName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonAcadrankCode", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MonBasicSchoolType",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    basicSchoolTypeID = table.Column<int>(type: "int", nullable: false),
                    basicSchoolTypeName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonBasicSchoolType", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MonBudgetFrom",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    budgetFromID = table.Column<int>(type: "int", nullable: false),
                    budgetFromName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonBudgetFrom", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MonContractType",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    contractTypeId = table.Column<int>(type: "int", nullable: false),
                    contractTypeName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonContractType", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MonCountryCode",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    countryID = table.Column<int>(type: "int", nullable: false),
                    countryName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    vcISO_3166Code = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    vcISO_A3 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    intISO_Number = table.Column<int>(type: "int", nullable: true),
                    intIsEUMember = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonCountryCode", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MonCustomDisciplineType",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    disciplineTypeName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonCustomDisciplineType", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MonEdForm",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    edFormID = table.Column<int>(type: "int", nullable: false),
                    edFormName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonEdForm", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MonEdPeriod",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    edPeriodID = table.Column<decimal>(type: "decimal(10,1)", nullable: false),
                    edPeriodName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonEdPeriod", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MonEkatte",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ekatteID = table.Column<int>(type: "int", nullable: false),
                    location = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    municipality = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    district = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonEkatte", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MonNsiCode",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nSIID = table.Column<int>(type: "int", nullable: false),
                    nSIName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonNsiCode", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MonOccupationCode",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    occupID = table.Column<int>(type: "int", nullable: false),
                    occupName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonOccupationCode", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MonOksExtendedInfo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    oksExtendedID = table.Column<int>(type: "int", nullable: false),
                    oksExtendedName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonOksExtendedInfo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MonOksSpecialityType",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    specialityTypeID = table.Column<int>(type: "int", nullable: false),
                    specialityTypeName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonOksSpecialityType", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MonProfGroup",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    profGroupID = table.Column<int>(type: "int", nullable: false),
                    profGroupName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    profGroupArea = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonProfGroup", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MonReasonsForAcc",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    reasonsForAccID = table.Column<int>(type: "int", nullable: false),
                    reasonsForAccName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonReasonsForAcc", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MonScareaCode",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    scAreaID = table.Column<int>(type: "int", nullable: false),
                    scAreaName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonScareaCode", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MonScdegreeCode",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    scDegreeID = table.Column<int>(type: "int", nullable: false),
                    scDegreeName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonScdegreeCode", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MonSchoolTypeZnp",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    schoolTypeID = table.Column<int>(type: "int", nullable: false),
                    schoolTypeName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonSchoolTypeZnp", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MonSeType",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sETypeID = table.Column<int>(type: "int", nullable: false),
                    sETypeName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    requireEducationalEstablishment = table.Column<short>(type: "smallint", nullable: false),
                    requireProfGroup = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonSeType", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MonStatusAction",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    actionID = table.Column<int>(type: "int", nullable: false),
                    actionName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonStatusAction", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MonStudyType",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    studyTypeID = table.Column<int>(type: "int", nullable: false),
                    studyTypeName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonStudyType", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MonUniversity",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    universityID = table.Column<int>(type: "int", nullable: false),
                    universityName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonUniversity", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PlanDisciplinesDelete",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    planId = table.Column<int>(type: "int", nullable: false),
                    disciplineId = table.Column<int>(type: "int", nullable: false),
                    academicEmployment = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    outdoorJobs = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    lectures = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    seminars = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    credits = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    typeId = table.Column<int>(type: "int", nullable: false),
                    note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    teacherName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    id_teachers = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanDisciplinesDelete", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PlanDisciplineTeacherLink",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_plan_disciplines = table.Column<int>(type: "int", nullable: false),
                    discipline = table.Column<int>(type: "int", nullable: false),
                    id_teacher = table.Column<int>(type: "int", nullable: false),
                    start_date = table.Column<DateTime>(type: "date", nullable: false),
                    end_date = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanDisciplineTeacherLink", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PlansDelete",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    abbreviation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    specialityId = table.Column<int>(type: "int", nullable: false),
                    year = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    course = table.Column<int>(type: "int", nullable: false),
                    semester = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    oLDID = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    dateAcceptedByFS = table.Column<DateTime>(type: "date", nullable: false),
                    dateAcceptedByAS = table.Column<DateTime>(type: "date", nullable: false),
                    dateStart = table.Column<DateTime>(type: "date", nullable: false),
                    dateEnd = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlansDelete", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ProtocolsDelete",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    number = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    specialityId = table.Column<int>(type: "int", nullable: false),
                    planId = table.Column<int>(type: "int", nullable: true),
                    disciplineId = table.Column<int>(type: "int", nullable: false),
                    isSingle = table.Column<int>(type: "int", nullable: false),
                    oLDID = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    inspector = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    teacherId = table.Column<int>(type: "int", nullable: true),
                    dateNormal = table.Column<DateTime>(type: "date", nullable: true),
                    dateFix = table.Column<DateTime>(type: "date", nullable: true),
                    dateLast = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProtocolsDelete", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ProtocolStudentsDelete",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    protocolId = table.Column<int>(type: "int", nullable: false),
                    studentId = table.Column<int>(type: "int", nullable: false),
                    credits = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    lectures = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    seminars = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    score_1 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    score_2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    score_3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProtocolStudentsDelete", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('0001-01-01T00:00:00.0000000')"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleUser",
                columns: table => new
                {
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleUser", x => new { x.RoleId, x.UserId });
                });

            migrationBuilder.CreateTable(
                name: "scheduler_tmp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subject = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false, defaultValueSql: "('Среща')"),
                    Location = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    IsAllDay = table.Column<bool>(type: "bit", nullable: true),
                    IsReadonly = table.Column<bool>(type: "bit", nullable: true),
                    RecurrenceRule = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    RecurrenceException = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    RecurrenceID = table.Column<int>(type: "int", nullable: true),
                    userid = table.Column<int>(type: "int", nullable: true),
                    speciality_Id = table.Column<int>(type: "int", nullable: true),
                    discipline_id = table.Column<int>(type: "int", nullable: true),
                    plan_year = table.Column<int>(type: "int", nullable: true),
                    course = table.Column<int>(type: "int", nullable: true),
                    edFormID = table.Column<int>(type: "int", nullable: true),
                    semester = table.Column<int>(type: "int", nullable: true),
                    specialityTypeID = table.Column<int>(type: "int", nullable: true),
                    speciality_Id_text = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    discipline_id_text = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CategoryColor = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    StartTimezone = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    EndTimezone = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    OwnerId = table.Column<int>(type: "int", nullable: true),
                    group_id = table.Column<int>(type: "int", nullable: true),
                    teacher_id = table.Column<int>(type: "int", nullable: true),
                    students_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scheduler_tmp", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UniCourse",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    courseExport = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniCourse", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "UniDiscipline",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniDiscipline", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "UniInfo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    academicYear = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    semester = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    code = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    bulstat = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    establishedYear = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    fullName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    shortName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    basicSchoolTypeId = table.Column<int>(type: "int", nullable: false),
                    schoolTypeId = table.Column<int>(type: "int", nullable: false),
                    budgetFromId = table.Column<int>(type: "int", nullable: false),
                    postCode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    city = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    website = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    phone1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    phone2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    phone3 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    phone4 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    phone5 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    fax = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    saliro_back_sync_data_version = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniInfo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "UniInfoDatabases",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomerBaza = table.Column<int>(type: "int", nullable: false),
                    kodBaza = table.Column<int>(type: "int", nullable: false),
                    naimenovanieBaza = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    broiOblasti = table.Column<int>(type: "int", nullable: false),
                    opisanieOblasti = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniInfoDatabases", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "UniInfoDatabasesCodes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dbName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniInfoDatabasesCodes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "UniInfoFinance",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    karierenCentar = table.Column<int>(type: "int", nullable: false),
                    sredstvaNID = table.Column<int>(type: "int", nullable: false),
                    subsidiaNID = table.Column<int>(type: "int", nullable: false),
                    studentskiObshtejitia = table.Column<int>(type: "int", nullable: false),
                    uchebnaPlosht = table.Column<int>(type: "int", nullable: false),
                    bibliotechenFond = table.Column<int>(type: "int", nullable: false),
                    polzwaneBibliotechenFond = table.Column<int>(type: "int", nullable: false),
                    obshtBudgetVU = table.Column<int>(type: "int", nullable: false),
                    stopanskiInventar = table.Column<int>(type: "int", nullable: false),
                    stoinostAdministrSgradi = table.Column<int>(type: "int", nullable: false),
                    stoinostJilishtniSgradi = table.Column<int>(type: "int", nullable: false),
                    stoinostDrugiSgradi = table.Column<int>(type: "int", nullable: false),
                    stoinostOborudvaneHardware = table.Column<int>(type: "int", nullable: false),
                    stoinostOborudvaneDrugiMashini = table.Column<int>(type: "int", nullable: false),
                    stoinostOborudvaneAvtomobili = table.Column<int>(type: "int", nullable: false),
                    stoinostOborudvaneDrugiTransSredstva = table.Column<int>(type: "int", nullable: false),
                    stoinostOborudvaneKapitaliziraniSredstva = table.Column<int>(type: "int", nullable: false),
                    mejdunarodnaMobilnost = table.Column<int>(type: "int", nullable: false),
                    mejdunarodnaMobilnostVavVU = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniInfoFinance", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "UniProfGroup",
                columns: table => new
                {
                    profGroupId = table.Column<int>(type: "int", nullable: false),
                    isAccredited = table.Column<int>(type: "int", nullable: false),
                    oLDID = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    accreditedFrom = table.Column<DateTime>(type: "date", nullable: true),
                    accreditedTo = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kia_uni_prof_group", x => x.profGroupId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfilePictureDataUrl = table.Column<string>(type: "text", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MonSpeciality",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<int>(type: "int", nullable: false),
                    areaVO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    profGroupName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    specialityName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    oksSpecialityTypeID = table.Column<int>(type: "int", nullable: false),
                    afterSpecialityTypeID = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    allowExport = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonSpeciality", x => x.id);
                    table.ForeignKey(
                        name: "kia_mon_speciality_ibfk_1",
                        column: x => x.oksSpecialityTypeID,
                        principalTable: "MonOksSpecialityType",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('0001-01-01T00:00:00.0000000')"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Group = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Identity",
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UniInfoMobilnost",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    profGroupId = table.Column<int>(type: "int", nullable: false),
                    studentiVUvProgrami = table.Column<int>(type: "int", nullable: false),
                    studentiES = table.Column<int>(type: "int", nullable: false),
                    programiVU = table.Column<int>(type: "int", nullable: false),
                    programiES = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniInfoMobilnost", x => x.id);
                    table.ForeignKey(
                        name: "FK_kia_uni_info_mobilnost_kia_uni_prof_group",
                        column: x => x.profGroupId,
                        principalTable: "UniProfGroup",
                        principalColumn: "profGroupId");
                });

            migrationBuilder.CreateTable(
                name: "UniInfoStipendii",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    profGroupId = table.Column<int>(type: "int", nullable: false),
                    suma = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniInfoStipendii", x => x.id);
                    table.ForeignKey(
                        name: "FK_kia_uni_info_stipendii_kia_uni_prof_group",
                        column: x => x.profGroupId,
                        principalTable: "UniProfGroup",
                        principalColumn: "profGroupId");
                });

            migrationBuilder.CreateTable(
                name: "ChatHistory",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ToUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChatHistory_Users_FromUserId",
                        column: x => x.FromUserId,
                        principalSchema: "Identity",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChatHistory_Users_ToUserId",
                        column: x => x.ToUserId,
                        principalSchema: "Identity",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pin = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    pinType = table.Column<int>(type: "int", nullable: false),
                    firstName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    middleName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    lastName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    gender = table.Column<int>(type: "int", nullable: false),
                    birthCountryId = table.Column<int>(type: "int", nullable: false),
                    birthDistrict = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    birthMunicipality = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    birthLocationId = table.Column<int>(type: "int", nullable: true),
                    citizenshipId = table.Column<int>(type: "int", nullable: false),
                    liveCountryId = table.Column<int>(type: "int", nullable: false),
                    liveDistrict = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    liveMunicipality = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    liveLocationId = table.Column<int>(type: "int", nullable: true),
                    fn = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    reasonsForAccId = table.Column<int>(type: "int", nullable: false),
                    stipendy = table.Column<int>(type: "int", nullable: false),
                    hostel = table.Column<int>(type: "int", nullable: false),
                    statusId = table.Column<int>(type: "int", nullable: false),
                    statusNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    universityId = table.Column<int>(type: "int", nullable: true),
                    restBase = table.Column<int>(type: "int", nullable: false),
                    internacionalProgram = table.Column<int>(type: "int", nullable: false),
                    photoName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    enrollOksSpecialtyTypeId = table.Column<int>(type: "int", nullable: true),
                    enrollOksExtendedInfoId = table.Column<int>(type: "int", nullable: true),
                    oLDID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    personalInfoStreet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    personalInfoTown = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    personalInfoPhones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    personalInfoEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    debtor = table.Column<int>(type: "int", nullable: false),
                    userid = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    birthDate = table.Column<DateTime>(type: "date", nullable: true),
                    statusDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.id);
                    table.ForeignKey(
                        name: "FK_kia_students_kia_mon_oks_speciality_type",
                        column: x => x.enrollOksSpecialtyTypeId,
                        principalTable: "MonOksSpecialityType",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_kia_students_kia_mon_status_action",
                        column: x => x.statusId,
                        principalTable: "MonStatusAction",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_kia_students_kia_students",
                        column: x => x.enrollOksExtendedInfoId,
                        principalTable: "MonOksExtendedInfo",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_students_users",
                        column: x => x.userid,
                        principalSchema: "Identity",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titleAndName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    pin = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    pinType = table.Column<int>(type: "int", nullable: false),
                    firstName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    middleName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    lastName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    gender = table.Column<int>(type: "int", nullable: false),
                    countryId = table.Column<int>(type: "int", nullable: false),
                    occupId = table.Column<int>(type: "int", nullable: false),
                    occupationContractNum = table.Column<int>(type: "int", nullable: false),
                    contractTypeId = table.Column<int>(type: "int", nullable: false),
                    contractNotes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    teacherStatus = table.Column<int>(type: "int", nullable: false),
                    requiredHoursNorm = table.Column<int>(type: "int", nullable: false),
                    realHoursNorm = table.Column<int>(type: "int", nullable: false),
                    scDegreeId = table.Column<int>(type: "int", nullable: false),
                    scAreaId = table.Column<int>(type: "int", nullable: false),
                    acadRankId = table.Column<int>(type: "int", nullable: false),
                    qualificationNotes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    photoName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    oLDID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userid = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    birthDate = table.Column<DateTime>(type: "date", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    email = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.id);
                    table.ForeignKey(
                        name: "FK_teachers_users",
                        column: x => x.userid,
                        principalSchema: "Identity",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "Identity",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                schema: "Identity",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "Identity",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                schema: "Identity",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Identity",
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "Identity",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                schema: "Identity",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "Identity",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UniSpeciality",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    profGroupId = table.Column<int>(type: "int", nullable: false),
                    oksId = table.Column<int>(type: "int", nullable: false),
                    specialityId = table.Column<int>(type: "int", nullable: false),
                    abbreviation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    edFormId = table.Column<int>(type: "int", nullable: false),
                    edPeriodId = table.Column<decimal>(type: "decimal(10,1)", nullable: false),
                    isAccredited = table.Column<int>(type: "int", nullable: false),
                    nsiCodeId = table.Column<int>(type: "int", nullable: true),
                    oksExtendedId = table.Column<int>(type: "int", nullable: false),
                    isClosed = table.Column<int>(type: "int", nullable: false),
                    characteristic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    oLDID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    accreditedFrom = table.Column<DateTime>(type: "date", nullable: true),
                    accreditedTo = table.Column<DateTime>(type: "date", nullable: true),
                    teacher_lecture_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniSpeciality", x => x.id);
                    table.ForeignKey(
                        name: "FK_kia_uni_speciality_kia_uni_prof_group",
                        column: x => x.profGroupId,
                        principalTable: "UniProfGroup",
                        principalColumn: "profGroupId");
                    table.ForeignKey(
                        name: "kia_uni_speciality_ibfk_2",
                        column: x => x.oksId,
                        principalTable: "MonOksSpecialityType",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "kia_uni_speciality_ibfk_3",
                        column: x => x.nsiCodeId,
                        principalTable: "MonNsiCode",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "kia_uni_speciality_ibfk_4",
                        column: x => x.specialityId,
                        principalTable: "MonSpeciality",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "StudentsStudyInfo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    studentId = table.Column<int>(type: "int", nullable: false),
                    prevStudyTypeId = table.Column<int>(type: "int", nullable: false),
                    prevStudyFinishYear = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    prevStudySchoolName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    prevStudyProfGroupId = table.Column<int>(type: "int", nullable: true),
                    prevStudySpeciality = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    prevStudyCountryId = table.Column<int>(type: "int", nullable: false),
                    prevStudyDistrict = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    prevStudyMunicipality = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    prevStudyLocationId = table.Column<int>(type: "int", nullable: true),
                    prevStudyDiplomSer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    prevStudyDiplomNum = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    prevStudyDiplomRN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    prevStudyDiplomDate = table.Column<DateTime>(type: "date", nullable: true),
                    prevStudyScore = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    prevStudyUniversityId = table.Column<int>(type: "int", nullable: true),
                    created = table.Column<DateTime>(type: "datetime2(0)", precision: 0, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsStudyInfo", x => x.id);
                    table.ForeignKey(
                        name: "FK_kia_students_study_info_kia_mon_se_type",
                        column: x => x.prevStudyTypeId,
                        principalTable: "MonSeType",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_kia_students_study_info_kia_students",
                        column: x => x.studentId,
                        principalTable: "Students",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_kia_students_study_info_kia_students_study_info",
                        column: x => x.prevStudyUniversityId,
                        principalTable: "MonUniversity",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "kia_students_study_info_ibfk_2",
                        column: x => x.prevStudyCountryId,
                        principalTable: "MonCountryCode",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DocumentTypeId = table.Column<int>(type: "int", nullable: false),
                    teacher = table.Column<int>(type: "int", nullable: true),
                    discipline = table.Column<int>(type: "int", nullable: true),
                    course = table.Column<int>(type: "int", nullable: true),
                    year = table.Column<int>(type: "int", nullable: true),
                    edformId = table.Column<int>(type: "int", nullable: true),
                    semester = table.Column<int>(type: "int", nullable: true),
                    specialityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Documents_DocumentTypes_DocumentTypeId",
                        column: x => x.DocumentTypeId,
                        principalTable: "DocumentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Documents_Teachers",
                        column: x => x.teacher,
                        principalTable: "Teachers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "TeacherLecture",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    teacherId = table.Column<int>(type: "int", nullable: false),
                    lecturingSpecialityId = table.Column<int>(type: "int", nullable: false),
                    lecturingEdFormId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherLecture", x => x.id);
                    table.ForeignKey(
                        name: "FK_kia_teacher_lecture_kia_mon_ed_form33",
                        column: x => x.lecturingEdFormId,
                        principalTable: "MonEdForm",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_kia_teacher_lecture_kia_teachers",
                        column: x => x.teacherId,
                        principalTable: "Teachers",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_TeacherLecture_MonSpeciality",
                        column: x => x.lecturingSpecialityId,
                        principalTable: "MonSpeciality",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Plans",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    abbreviation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    specialityId = table.Column<int>(type: "int", nullable: false),
                    year = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    course = table.Column<int>(type: "int", nullable: false),
                    semester = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    oLDID = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    dateAcceptedByFS = table.Column<DateTime>(type: "date", nullable: false),
                    dateAcceptedByAS = table.Column<DateTime>(type: "date", nullable: false),
                    dateStart = table.Column<DateTime>(type: "date", nullable: false),
                    dateEnd = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plans", x => x.id);
                    table.ForeignKey(
                        name: "FK_kia_plans_kia_uni_course",
                        column: x => x.course,
                        principalTable: "UniCourse",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_kia_plans_kia_uni_speciality",
                        column: x => x.specialityId,
                        principalTable: "UniSpeciality",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "StudentEnrolled",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    studentId = table.Column<int>(type: "int", nullable: false),
                    year = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    specialityId = table.Column<int>(type: "int", nullable: false),
                    course = table.Column<int>(type: "int", nullable: false),
                    specialityNum = table.Column<int>(type: "int", nullable: false),
                    studyTypeId = table.Column<int>(type: "int", nullable: false),
                    orderNum = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    score = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    change_date = table.Column<DateTime>(type: "datetime2(0)", precision: 0, nullable: false),
                    orderDate = table.Column<DateTime>(type: "date", nullable: true),
                    orderEndDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentEnrolled", x => x.id);
                    table.ForeignKey(
                        name: "FK_kia_student_enrolled_kia_mon_study_type",
                        column: x => x.studyTypeId,
                        principalTable: "MonStudyType",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_kia_student_enrolled_kia_students",
                        column: x => x.studentId,
                        principalTable: "Students",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_kia_student_enrolled_kia_uni_speciality",
                        column: x => x.specialityId,
                        principalTable: "UniSpeciality",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "DocumentExtendedAttributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EntityId = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<byte>(type: "tinyint", nullable: false),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Decimal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Json = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExternalId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Group = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentExtendedAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DocumentExtendedAttributes_Documents_EntityId",
                        column: x => x.EntityId,
                        principalTable: "Documents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlanDisciplines",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    planId = table.Column<int>(type: "int", nullable: false),
                    disciplineId = table.Column<int>(type: "int", nullable: false),
                    academicEmployment = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    outdoorJobs = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    lectures = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    seminars = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    credits = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    typeId = table.Column<int>(type: "int", nullable: false),
                    note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    teacherName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    id_teachers = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanDisciplines", x => x.id);
                    table.ForeignKey(
                        name: "FK_kia_plan_disciplines_kia_mon_custom_discipline_type",
                        column: x => x.typeId,
                        principalTable: "MonCustomDisciplineType",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_kia_plan_disciplines_kia_plans",
                        column: x => x.planId,
                        principalTable: "Plans",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_kia_plan_disciplines_kia_uni_discipline",
                        column: x => x.disciplineId,
                        principalTable: "UniDiscipline",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Protocols",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    number = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    specialityId = table.Column<int>(type: "int", nullable: false),
                    planId = table.Column<int>(type: "int", nullable: true),
                    disciplineId = table.Column<int>(type: "int", nullable: false),
                    isSingle = table.Column<int>(type: "int", nullable: false),
                    oLDID = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    inspector = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    teacherId = table.Column<int>(type: "int", nullable: true),
                    dateNormal = table.Column<DateTime>(type: "date", nullable: true),
                    dateFix = table.Column<DateTime>(type: "date", nullable: true),
                    dateLast = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Protocols", x => x.id);
                    table.ForeignKey(
                        name: "FK_kia_protocols_kia_uni_discipline",
                        column: x => x.disciplineId,
                        principalTable: "UniDiscipline",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_kia_protocols_kia_uni_speciality",
                        column: x => x.specialityId,
                        principalTable: "UniSpeciality",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "kia_protocols_ibfk_1",
                        column: x => x.planId,
                        principalTable: "Plans",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "ProtocolStudents",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    protocolId = table.Column<int>(type: "int", nullable: false),
                    studentId = table.Column<int>(type: "int", nullable: false),
                    credits = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    lectures = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    seminars = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    score_1 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    score_2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    score_3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProtocolStudents", x => x.id);
                    table.ForeignKey(
                        name: "FK_kia_protocol_students_kia_protocols1",
                        column: x => x.protocolId,
                        principalTable: "Protocols",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_kia_protocol_students_kia_students4",
                        column: x => x.studentId,
                        principalTable: "Students",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "AuditTrailsUserId",
                table: "AuditTrails",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatHistory_FromUserId",
                table: "ChatHistory",
                column: "FromUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatHistory_ToUserId",
                table: "ChatHistory",
                column: "ToUserId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentExtendedAttributes_EntityId",
                table: "DocumentExtendedAttributes",
                column: "EntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_DocumentTypeId",
                table: "Documents",
                column: "DocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_teacher",
                table: "Documents",
                column: "teacher");

            migrationBuilder.CreateIndex(
                name: "IX_MonSpeciality_oksSpecialityTypeID",
                table: "MonSpeciality",
                column: "oksSpecialityTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_PlanDisciplines_disciplineId",
                table: "PlanDisciplines",
                column: "disciplineId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanDisciplines_planId",
                table: "PlanDisciplines",
                column: "planId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanDisciplines_typeId",
                table: "PlanDisciplines",
                column: "typeId");

            migrationBuilder.CreateIndex(
                name: "IX_Plans_course",
                table: "Plans",
                column: "course");

            migrationBuilder.CreateIndex(
                name: "IX_Plans_specialityId",
                table: "Plans",
                column: "specialityId");

            migrationBuilder.CreateIndex(
                name: "IX_Protocols_disciplineId",
                table: "Protocols",
                column: "disciplineId");

            migrationBuilder.CreateIndex(
                name: "IX_Protocols_planId",
                table: "Protocols",
                column: "planId");

            migrationBuilder.CreateIndex(
                name: "IX_Protocols_specialityId",
                table: "Protocols",
                column: "specialityId");

            migrationBuilder.CreateIndex(
                name: "IND_kia_protocol_studens_protocolid",
                table: "ProtocolStudents",
                column: "protocolId");

            migrationBuilder.CreateIndex(
                name: "IX_ProtocolStudents_studentId",
                table: "ProtocolStudents",
                column: "studentId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                schema: "Identity",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "Identity",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "([NormalizedName] IS NOT NULL)");

            migrationBuilder.CreateIndex(
                name: "IX_StudentEnrolled_specialityId",
                table: "StudentEnrolled",
                column: "specialityId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentEnrolled_studentId",
                table: "StudentEnrolled",
                column: "studentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentEnrolled_studyTypeId",
                table: "StudentEnrolled",
                column: "studyTypeId");

            migrationBuilder.CreateIndex(
                name: "Ind_students_fn",
                table: "Students",
                column: "fn");

            migrationBuilder.CreateIndex(
                name: "IX_Students_enrollOksExtendedInfoId",
                table: "Students",
                column: "enrollOksExtendedInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_enrollOksSpecialtyTypeId",
                table: "Students",
                column: "enrollOksSpecialtyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_statusId",
                table: "Students",
                column: "statusId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_userid",
                table: "Students",
                column: "userid");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsStudyInfo_prevStudyCountryId",
                table: "StudentsStudyInfo",
                column: "prevStudyCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsStudyInfo_prevStudyTypeId",
                table: "StudentsStudyInfo",
                column: "prevStudyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsStudyInfo_prevStudyUniversityId",
                table: "StudentsStudyInfo",
                column: "prevStudyUniversityId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsStudyInfo_studentId",
                table: "StudentsStudyInfo",
                column: "studentId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherLecture_lecturingEdFormId",
                table: "TeacherLecture",
                column: "lecturingEdFormId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherLecture_lecturingSpecialityId",
                table: "TeacherLecture",
                column: "lecturingSpecialityId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherLecture_teacherId",
                table: "TeacherLecture",
                column: "teacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_userid",
                table: "Teachers",
                column: "userid");

            migrationBuilder.CreateIndex(
                name: "IX_UniInfoMobilnost_profGroupId",
                table: "UniInfoMobilnost",
                column: "profGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_UniInfoStipendii_profGroupId",
                table: "UniInfoStipendii",
                column: "profGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_UniSpeciality_nsiCodeId",
                table: "UniSpeciality",
                column: "nsiCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_UniSpeciality_oksId",
                table: "UniSpeciality",
                column: "oksId");

            migrationBuilder.CreateIndex(
                name: "IX_UniSpeciality_profGroupId",
                table: "UniSpeciality",
                column: "profGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_UniSpeciality_specialityId",
                table: "UniSpeciality",
                column: "specialityId");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                schema: "Identity",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                schema: "Identity",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                schema: "Identity",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "Identity",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "Identity",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "([NormalizedUserName] IS NOT NULL)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditTrails");

            migrationBuilder.DropTable(
                name: "ChatHistory");

            migrationBuilder.DropTable(
                name: "DocumentExtendedAttributes");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "MonAcadrankCode");

            migrationBuilder.DropTable(
                name: "MonBasicSchoolType");

            migrationBuilder.DropTable(
                name: "MonBudgetFrom");

            migrationBuilder.DropTable(
                name: "MonContractType");

            migrationBuilder.DropTable(
                name: "MonEdPeriod");

            migrationBuilder.DropTable(
                name: "MonEkatte");

            migrationBuilder.DropTable(
                name: "MonOccupationCode");

            migrationBuilder.DropTable(
                name: "MonProfGroup");

            migrationBuilder.DropTable(
                name: "MonReasonsForAcc");

            migrationBuilder.DropTable(
                name: "MonScareaCode");

            migrationBuilder.DropTable(
                name: "MonScdegreeCode");

            migrationBuilder.DropTable(
                name: "MonSchoolTypeZnp");

            migrationBuilder.DropTable(
                name: "PlanDisciplines");

            migrationBuilder.DropTable(
                name: "PlanDisciplinesDelete");

            migrationBuilder.DropTable(
                name: "PlanDisciplineTeacherLink");

            migrationBuilder.DropTable(
                name: "PlansDelete");

            migrationBuilder.DropTable(
                name: "ProtocolsDelete");

            migrationBuilder.DropTable(
                name: "ProtocolStudents");

            migrationBuilder.DropTable(
                name: "ProtocolStudentsDelete");

            migrationBuilder.DropTable(
                name: "RoleClaims",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "RoleUser");

            migrationBuilder.DropTable(
                name: "scheduler_tmp");

            migrationBuilder.DropTable(
                name: "StudentEnrolled");

            migrationBuilder.DropTable(
                name: "StudentsStudyInfo");

            migrationBuilder.DropTable(
                name: "TeacherLecture");

            migrationBuilder.DropTable(
                name: "UniInfo");

            migrationBuilder.DropTable(
                name: "UniInfoDatabases");

            migrationBuilder.DropTable(
                name: "UniInfoDatabasesCodes");

            migrationBuilder.DropTable(
                name: "UniInfoFinance");

            migrationBuilder.DropTable(
                name: "UniInfoMobilnost");

            migrationBuilder.DropTable(
                name: "UniInfoStipendii");

            migrationBuilder.DropTable(
                name: "UserClaims",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "UserLogins",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "UserRoles",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "UserTokens",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "MonCustomDisciplineType");

            migrationBuilder.DropTable(
                name: "Protocols");

            migrationBuilder.DropTable(
                name: "MonStudyType");

            migrationBuilder.DropTable(
                name: "MonSeType");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "MonUniversity");

            migrationBuilder.DropTable(
                name: "MonCountryCode");

            migrationBuilder.DropTable(
                name: "MonEdForm");

            migrationBuilder.DropTable(
                name: "Roles",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "DocumentTypes");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "UniDiscipline");

            migrationBuilder.DropTable(
                name: "Plans");

            migrationBuilder.DropTable(
                name: "MonStatusAction");

            migrationBuilder.DropTable(
                name: "MonOksExtendedInfo");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "UniCourse");

            migrationBuilder.DropTable(
                name: "UniSpeciality");

            migrationBuilder.DropTable(
                name: "UniProfGroup");

            migrationBuilder.DropTable(
                name: "MonNsiCode");

            migrationBuilder.DropTable(
                name: "MonSpeciality");

            migrationBuilder.DropTable(
                name: "MonOksSpecialityType");

            migrationBuilder.DropSequence(
                name: "CountBy1");
        }
    }
}
