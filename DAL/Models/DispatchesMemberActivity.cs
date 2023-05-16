using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("DISPATCHES_MEMBER_ACTIVITY")]
public partial class DispatchesMemberActivity
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("PROCESS_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ProcessCode { get; set; }

    [Column("ASSIGNER")]
    [StringLength(255)]
    public string Assigner { get; set; }

    [Column("USER_ID")]
    [StringLength(50)]
    public string UserId { get; set; }

    [Column("ROLE")]
    public int? Role { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("GROUP_USER_CODE")]
    [StringLength(255)]
    public string GroupUserCode { get; set; }

    [Column("COMMENT")]
    [StringLength(2000)]
    public string Comment { get; set; }

    [Column("ASSIGNEE_CONFIRM")]
    [StringLength(255)]
    public string AssigneeConfirm { get; set; }

    [Column("CONFIRM_TIME")]
    public DateTime? ConfirmTime { get; set; }

    [Column("DEAD_LINE")]
    public DateTime? DeadLine { get; set; }
}
