using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("WORKFLOW_SETTING")]
public partial class WorkflowSetting
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("WORKFLOW_CODE")]
    [StringLength(255)]
    public string WorkflowCode { get; set; }

    [Column("ACTIVITY_INITIAL")]
    [StringLength(255)]
    public string ActivityInitial { get; set; }

    [Column("TRANSITION_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string TransitionCode { get; set; }

    [Column("ACTIVITY_DESTINATION")]
    [StringLength(255)]
    [Unicode(false)]
    public string ActivityDestination { get; set; }

    [Column("COMMAND")]
    public string Command { get; set; }

    [Column("CREATED_BY")]
    [StringLength(100)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(100)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(100)]
    [Unicode(false)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }
}
