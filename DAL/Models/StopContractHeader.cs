using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("STOP_CONTRACT_HEADER")]
public partial class StopContractHeader
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("DECISION_NUM")]
    [StringLength(255)]
    public string DecisionNum { get; set; }

    [Column("TITLE")]
    [StringLength(255)]
    public string Title { get; set; }

    [Column("WORKFLOW_CAT")]
    [StringLength(255)]
    public string WorkflowCat { get; set; }

    [Column("NOTED")]
    [StringLength(500)]
    public string Noted { get; set; }

    [Column("DECISION_DATE")]
    public DateTime? DecisionDate { get; set; }

    [Column("DECISION_BY")]
    [StringLength(255)]
    public string DecisionBy { get; set; }

    [Column("APPROVED_BY")]
    [StringLength(255)]
    public string ApprovedBy { get; set; }

    [Column("APPROVED_TIME")]
    public DateTime? ApprovedTime { get; set; }

    [Column("STATUS")]
    public string Status { get; set; }

    [Column("STATUS_LOG")]
    public string StatusLog { get; set; }

    [Column("JSON_DATA")]
    public string JsonData { get; set; }

    [Column("FLAG")]
    public bool? Flag { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(50)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(50)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }
}
