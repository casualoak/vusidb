using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VusiOnline.Shared.Models
{
    public partial class Employee
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("username")]
        [StringLength(255)]
        public string Username { get; set; } = null!;
        [Column("userpass")]
        public string? Userpass { get; set; }
        [Column("name")]
        public string? Name { get; set; }
        [Column("addressStreetName")]
        [StringLength(255)]
        public string? AddressStreetName { get; set; }
        [Column("addressStreetNumber")]
        [StringLength(255)]
        public string? AddressStreetNumber { get; set; }
        [Column("addressCity")]
        [StringLength(255)]
        public string? AddressCity { get; set; }
        [Column("addressPostCode")]
        [StringLength(255)]
        public string? AddressPostCode { get; set; }
        [Column("landline")]
        [StringLength(255)]
        public string? Landline { get; set; }
        [Column("landlineInternal")]
        [StringLength(255)]
        public string? LandlineInternal { get; set; }
        [Column("mobileFirst")]
        [StringLength(255)]
        public string? MobileFirst { get; set; }
        [Column("mobileSecond")]
        [StringLength(255)]
        public string? MobileSecond { get; set; }
        [Column("fax")]
        [StringLength(255)]
        public string? Fax { get; set; }
        [Column("email")]
        [StringLength(255)]
        public string? Email { get; set; }
        [Column("accessLevel")]
        public short AccessLevel { get; set; }
        [Column("photoName")]
        [StringLength(255)]
        public string? PhotoName { get; set; }
        [Column("userid")]
        [StringLength(255)]
        public string? Userid { get; set; }
    }
}
