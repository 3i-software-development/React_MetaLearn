using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[PrimaryKey("UserId", "RoleId")]
[Table("ASP_NET_USER_ROLES")]
[Index("RoleId", Name = "IX_ASP_NET_USER_ROLES_ROLE_ID")]
public partial class AspNetUserRole
{
    [Key]
    [Column("USER_ID")]
    public string UserId { get; set; }

    [Key]
    [Column("ROLE_ID")]
    public string RoleId { get; set; }
}
