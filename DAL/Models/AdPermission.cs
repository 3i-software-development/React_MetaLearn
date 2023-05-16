using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("AD_PERMISSION")]
public partial class AdPermission
{
    [Column("APPLICATION_CODE")]
    [StringLength(50)]
    public string ApplicationCode { get; set; }

    [Column("FUNCTION_CODE")]
    [StringLength(50)]
    public string FunctionCode { get; set; }

    [Column("RESOURCE_CODE")]
    [StringLength(100)]
    public string ResourceCode { get; set; }

    [Column("GROUP_USER_CODE")]
    [StringLength(50)]
    public string GroupUserCode { get; set; }

    [Column("USER_ID")]
    [StringLength(50)]
    public string UserId { get; set; }

    [Column("ROLE_ID")]
    [StringLength(50)]
    public string RoleId { get; set; }

    [Column("EXPIRED_DATE")]
    public DateTime? ExpiredDate { get; set; }

    [Key]
    [Column("PERMISSION_ID")]
    public int PermissionId { get; set; }
}
