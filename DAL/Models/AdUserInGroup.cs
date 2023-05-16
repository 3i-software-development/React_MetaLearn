using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("AD_USER_IN_GROUP")]
public partial class AdUserInGroup
{
    [Key]
    [Column("USER_IN_GROUP_ID")]
    public int UserInGroupId { get; set; }

    [Column("GROUP_USER_CODE")]
    [StringLength(50)]
    public string GroupUserCode { get; set; }

    [Column("USER_ID")]
    [StringLength(50)]
    public string UserId { get; set; }

    [Column("ROLE_ID")]
    [StringLength(50)]
    public string RoleId { get; set; }

    [Column("GRANT_ALL")]
    public bool? GrantAll { get; set; }

    [Column("IS_MAIN")]
    public bool? IsMain { get; set; }

    [Column("BRANCH_REFERENCE")]
    [StringLength(2000)]
    public string BranchReference { get; set; }

    [Column("APPLICATION_CODE")]
    [StringLength(50)]
    public string ApplicationCode { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("BRANCH")]
    [StringLength(50)]
    [Unicode(false)]
    public string Branch { get; set; }
}
