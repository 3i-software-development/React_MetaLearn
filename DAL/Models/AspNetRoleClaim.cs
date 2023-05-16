using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("ASP_NET_ROLE_CLAIMS")]
[Index("RoleId", Name = "IX_ASP_NET_ROLE_CLAIMS_ROLE_ID")]
public partial class AspNetRoleClaim
{
    [Key]
    [Column("ID", TypeName = "decimal(10, 0)")]
    public decimal Id { get; set; }

    [Column("CLAIM_TYPE")]
    public string ClaimType { get; set; }

    [Column("CLAIM_VALUE")]
    public string ClaimValue { get; set; }

    [Required]
    [Column("ROLE_ID")]
    public string RoleId { get; set; }
}
