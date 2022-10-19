using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    public partial class UniInfoDatabase
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("nomerBaza")]
        public int NomerBaza { get; set; }
        [Column("kodBaza")]
        public int KodBaza { get; set; }
        [Column("naimenovanieBaza")]
        [StringLength(255)]
        public string NaimenovanieBaza { get; set; } = null!;
        [Column("broiOblasti")]
        public int BroiOblasti { get; set; }
        [Column("opisanieOblasti")]
        public string OpisanieOblasti { get; set; } = null!;
    }
}
