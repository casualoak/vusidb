using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Table("MonContractType")]
    public partial class MonContractType
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("contractTypeId")]
        public int ContractTypeId { get; set; }
        [Column("contractTypeName")]
        [StringLength(255)]
        public string? ContractTypeName { get; set; }
    }
}
