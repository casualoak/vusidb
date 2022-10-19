using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    [Table("UniInfoFinance")]
    public partial class UniInfoFinance
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("karierenCentar")]
        public int KarierenCentar { get; set; }
        [Column("sredstvaNID")]
        public int SredstvaNid { get; set; }
        [Column("subsidiaNID")]
        public int SubsidiaNid { get; set; }
        [Column("studentskiObshtejitia")]
        public int StudentskiObshtejitia { get; set; }
        [Column("uchebnaPlosht")]
        public int UchebnaPlosht { get; set; }
        [Column("bibliotechenFond")]
        public int BibliotechenFond { get; set; }
        [Column("polzwaneBibliotechenFond")]
        public int PolzwaneBibliotechenFond { get; set; }
        [Column("obshtBudgetVU")]
        public int ObshtBudgetVu { get; set; }
        [Column("stopanskiInventar")]
        public int StopanskiInventar { get; set; }
        [Column("stoinostAdministrSgradi")]
        public int StoinostAdministrSgradi { get; set; }
        [Column("stoinostJilishtniSgradi")]
        public int StoinostJilishtniSgradi { get; set; }
        [Column("stoinostDrugiSgradi")]
        public int StoinostDrugiSgradi { get; set; }
        [Column("stoinostOborudvaneHardware")]
        public int StoinostOborudvaneHardware { get; set; }
        [Column("stoinostOborudvaneDrugiMashini")]
        public int StoinostOborudvaneDrugiMashini { get; set; }
        [Column("stoinostOborudvaneAvtomobili")]
        public int StoinostOborudvaneAvtomobili { get; set; }
        [Column("stoinostOborudvaneDrugiTransSredstva")]
        public int StoinostOborudvaneDrugiTransSredstva { get; set; }
        [Column("stoinostOborudvaneKapitaliziraniSredstva")]
        public int StoinostOborudvaneKapitaliziraniSredstva { get; set; }
        [Column("mejdunarodnaMobilnost")]
        public int MejdunarodnaMobilnost { get; set; }
        [Column("mejdunarodnaMobilnostVavVU")]
        public int MejdunarodnaMobilnostVavVu { get; set; }
    }
}
