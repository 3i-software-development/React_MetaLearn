using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Model;

[Table("JOB_CARD_ASSIGNEE")]
[Index("IsDeleted", Name = "PK_DEPARTMENT_CARD_JOB")]
[Index("IsDeleted", Name = "PK_USER_CARD_JOB")]
public partial class JobCardAssignee
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

    [Column("ITEM")]
    public string Item { get; set; }

    [Column("DEPARTMENT_CODE")]
    [StringLength(255)]
    public string DepartmentCode { get; set; }

    [Column("GROUP_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string GroupCode { get; set; }

    [Column("CARD_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string CardCode { get; set; }

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

    [Column("LOG")]
    public string Log { get; set; }
}
