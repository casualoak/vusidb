using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    public partial class UniInfoDatabasesCode
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("dbName")]
        [StringLength(100)]
        public string DbName { get; set; } = null!;
    }
}
