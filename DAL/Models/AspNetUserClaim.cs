using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("ASP_NET_USER_CLAIMS")]
[Index("UserId", Name = "IX_ASP_NET_USER_CLAIMS_USER_ID")]
public partial class AspNetUserClaim
{
    [Key]
    [Column("ID", TypeName = "decimal(10, 0)")]
    public decimal Id { get; set; }

    [Column("CLAIM_TYPE")]
    public string ClaimType { get; set; }

    [Column("CLAIM_VALUE")]
    public string ClaimValue { get; set; }

    [Required]
    [Column("USER_ID")]
    public string UserId { get; set; }
}
