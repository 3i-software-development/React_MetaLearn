using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("WORK_OS_CARD")]
public partial class WorkOsCard
{
    [Column("CARD_ID")]
    public int CardId { get; set; }

    [Key]
    [Column("CARD_CODE")]
    [StringLength(100)]
    public string CardCode { get; set; }

    [Column("CARD_NAME")]
    [StringLength(255)]
    public string CardName { get; set; }

    [Column("LIST_CODE")]
    [StringLength(100)]
    public string ListCode { get; set; }

    [Column("LABELS")]
    [StringLength(255)]
    public string Labels { get; set; }

    [Column("MEMBER")]
    [StringLength(255)]
    public string Member { get; set; }

    [Column("CHECK_LIST")]
    [StringLength(255)]
    public string CheckList { get; set; }

    [Column("ATTACHMENT_LIST")]
    [StringLength(255)]
    public string AttachmentList { get; set; }

    [Column("COMMENT_LIST")]
    [StringLength(255)]
    public string CommentList { get; set; }

    [Column("DESCRIPTION")]
    public string Description { get; set; }

    [Column("WORK_TYPE")]
    [StringLength(255)]
    public string WorkType { get; set; }

    [Column("STATUS")]
    public string Status { get; set; }

    [Column("CARD_LEVEL")]
    [StringLength(255)]
    public string CardLevel { get; set; }

    [Column("COMPLETED", TypeName = "decimal(14, 2)")]
    public decimal Completed { get; set; }

    [Column("COMPLETED_TIME")]
    public DateTime? CompletedTime { get; set; }

    [Column("COST", TypeName = "money")]
    public decimal Cost { get; set; }

    [Column("CURRENCY")]
    [StringLength(100)]
    [Unicode(false)]
    public string Currency { get; set; }

    [Column("DEADLINE")]
    public DateTime Deadline { get; set; }

    [Column("DEVICE")]
    [StringLength(255)]
    public string Device { get; set; }

    [Column("BEGIN_TIME")]
    public DateTime BeginTime { get; set; }

    [Column("WEIGHT_NUM", TypeName = "decimal(14, 2)")]
    public decimal WeightNum { get; set; }

    [Column("PROGRESS", TypeName = "decimal(14, 2)")]
    public decimal Progress { get; set; }

    [Column("END_TIME")]
    public DateTime? EndTime { get; set; }

    [Column("QUANTITATIVE", TypeName = "decimal(14, 2)")]
    public decimal? Quantitative { get; set; }

    [Column("UNIT")]
    [StringLength(50)]
    [Unicode(false)]
    public string Unit { get; set; }

    [Column("LST_USER")]
    public string LstUser { get; set; }

    [Column("CREATED_DATE")]
    public DateTime? CreatedDate { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("INHERIT")]
    [StringLength(255)]
    public string Inherit { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(50)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("LIST_USER_VIEW")]
    public string ListUserView { get; set; }

    [Column("WORKFLOW_CODE")]
    [StringLength(255)]
    public string WorkflowCode { get; set; }

    [Column("JSON_ASSIGN")]
    public string JsonAssign { get; set; }

    [Column("JSON_STATUS_LOG")]
    public string JsonStatusLog { get; set; }

    [Column("IS_LOCK")]
    public bool? IsLock { get; set; }

    [Column("LOCK_SHARE")]
    public string LockShare { get; set; }

    [Column("IS_RECURRENT")]
    public bool? IsRecurrent { get; set; }

    [Column("CYCLE")]
    [StringLength(255)]
    public string Cycle { get; set; }
}
