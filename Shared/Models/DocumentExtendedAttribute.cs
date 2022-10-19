using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Index("EntityId", Name = "IX_DocumentExtendedAttributes_EntityId")]
    public partial class DocumentExtendedAttribute
    {
        [Key]
        public int Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int EntityId { get; set; }
        public byte Type { get; set; }
        public string Key { get; set; } = null!;
        public string? Text { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Decimal { get; set; }
        public DateTime? DateTime { get; set; }
        public string? Json { get; set; }
        public string? ExternalId { get; set; }
        public string? Group { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }

        [ForeignKey("EntityId")]
        [InverseProperty("DocumentExtendedAttributes")]
        public virtual Document Entity { get; set; } = null!;
    }
}
