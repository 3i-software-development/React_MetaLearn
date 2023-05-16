using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("POOL_MEMBER_NOTIFICATION")]
public partial class PoolMemberNotification
{
    /// <summary>
    /// Customer Id
    /// </summary>
    [Key]
    [Column("NOTIFY_ID")]
    public int NotifyId { get; set; }

    [Column("ASSIGNER")]
    public string Assigner { get; set; }

    [Column("ASSIGNER_TIME")]
    public DateTime? AssignerTime { get; set; }

    [Column("ASSIGNEE")]
    public string Assignee { get; set; }

    [Column("ASSIGNEE_TIME")]
    public DateTime? AssigneeTime { get; set; }

    [Column("CONFIRM_TIME")]
    public DateTime? ConfirmTime { get; set; }

    [Column("MODULE_NAME")]
    [StringLength(255)]
    public string ModuleName { get; set; }

    [Column("TITLE")]
    [StringLength(255)]
    public string Title { get; set; }

    [Column("LINK")]
    [StringLength(255)]
    public string Link { get; set; }
}
