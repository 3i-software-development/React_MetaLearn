using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("EXCUTER_CONTROL_ROLE_INST")]
public partial class ExcuterControlRoleInst
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("USER_ID")]
    [StringLength(100)]
    public string UserId { get; set; }

    [Column("ROLE")]
    [StringLength(100)]
    public string Role { get; set; }

    [Column("DEPARTMENT_CODE")]
    [StringLength(255)]
    public string DepartmentCode { get; set; }

    [Column("GROUP_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string GroupCode { get; set; }

    [Column("ACTIVITY_CODE_INST")]
    [StringLength(255)]
    [Unicode(false)]
    public string ActivityCodeInst { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("CREATED_BY")]
    [StringLength(100)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(100)]
    [Unicode(false)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("APPROVE")]
    public bool? Approve { get; set; }

    [Column("APPROVE_TIME")]
    public DateTime? ApproveTime { get; set; }

    [Column("BRANCH")]
    [StringLength(255)]
    public string Branch { get; set; }

    [Column("STATUS")]
    [StringLength(100)]
    [Unicode(false)]
    public string Status { get; set; }
}
