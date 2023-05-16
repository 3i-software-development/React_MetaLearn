using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("ACTIVITY_INSTANCE")]
public partial class ActivityInstance
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("ACTIVITY_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ActivityCode { get; set; }

    [Column("TITLE")]
    [StringLength(255)]
    public string Title { get; set; }

    [Column("DURATION", TypeName = "decimal(18, 0)")]
    public decimal? Duration { get; set; }

    [Column("UNIT")]
    [StringLength(255)]
    public string Unit { get; set; }

    [Column("LOCATED")]
    [StringLength(255)]
    public string Located { get; set; }

    [Column("STATUS")]
    [StringLength(255)]
    public string Status { get; set; }

    [Column("DESC")]
    public string Desc { get; set; }

    [Column("SHAPE_JSON")]
    public string ShapeJson { get; set; }

    [Column("GROUP")]
    [StringLength(255)]
    [Unicode(false)]
    public string Group { get; set; }

    [Column("TYPE")]
    [StringLength(255)]
    [Unicode(false)]
    public string Type { get; set; }

    [Column("WORKFLOW_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string WorkflowCode { get; set; }

    [Column("CREATED_BY")]
    [StringLength(100)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(100)]
    [Unicode(false)]
    public string UpdatedBy { get; set; }

    [Column("DELETED_BY")]
    [StringLength(100)]
    [Unicode(false)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("ACTIVITY_INST_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ActivityInstCode { get; set; }

    [Column("START_TIME")]
    public DateTime? StartTime { get; set; }

    [Column("END_TIME")]
    public DateTime? EndTime { get; set; }

    [Column("LOG_COUNT_DOWN")]
    public string LogCountDown { get; set; }

    [Column("LOCK_SHARE")]
    public string LockShare { get; set; }

    [Column("WF_INST_RELATIVE")]
    public string WfInstRelative { get; set; }

    [Column("JSON_STATUS_LOG")]
    public string JsonStatusLog { get; set; }
}
