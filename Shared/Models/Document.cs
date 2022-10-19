using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Index("DocumentTypeId", Name = "IX_Documents_DocumentTypeId")]
    public partial class Document
    {
        public Document()
        {
            DocumentExtendedAttributes = new HashSet<DocumentExtendedAttribute>();
        }

        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? FileName { get; set; }
        public bool IsPublic { get; set; }
        [Column("URL")]
        public string? Url { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int DocumentTypeId { get; set; }
        [Column("teacher")]
        public int? Teacher { get; set; }
        [Column("discipline")]
        public int? Discipline { get; set; }
        [Column("course")]
        public int? Course { get; set; }
        [Column("year")]
        public int? Year { get; set; }
        [Column("edformId")]
        public int? EdformId { get; set; }
        [Column("semester")]
        public int? Semester { get; set; }
        [Column("specialityId")]
        public int? SpecialityId { get; set; }

        [ForeignKey("DocumentTypeId")]
        [InverseProperty("Documents")]
        public virtual DocumentType DocumentType { get; set; } = null!;
        [ForeignKey("Teacher")]
        [InverseProperty("Documents")]
        public virtual Teacher? TeacherNavigation { get; set; }
        [InverseProperty("Entity")]
        public virtual ICollection<DocumentExtendedAttribute> DocumentExtendedAttributes { get; set; }
    }
}
