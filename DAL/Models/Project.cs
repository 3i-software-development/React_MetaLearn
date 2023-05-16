using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("PROJECT")]
public partial class Project
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("PROJECT_CODE")]
    [StringLength(100)]
    public string ProjectCode { get; set; }

    [Column("PROJECT_TITLE")]
    [StringLength(255)]
    public string ProjectTitle { get; set; }

    [Column("BUDGET")]
    public double? Budget { get; set; }

    [Column("CURRENCY")]
    [StringLength(50)]
    public string Currency { get; set; }

    [Column("PRJ_SKILL_KEYWORD")]
    [StringLength(50)]
    public string PrjSkillKeyword { get; set; }

    [Column("PRJ_STATUS")]
    [StringLength(50)]
    public string PrjStatus { get; set; }

    [Column("SET_PRIORITY")]
    public double? SetPriority { get; set; }

    [Column("PRJ_MODE")]
    [StringLength(100)]
    public string PrjMode { get; set; }

    [Column("START_TIME")]
    public DateTime StartTime { get; set; }

    [Column("END_TIME")]
    public DateTime EndTime { get; set; }

    [Column("VERSION")]
    public int? Version { get; set; }

    [Column("LANGUAGE")]
    [StringLength(100)]
    [Unicode(false)]
    public string Language { get; set; }

    [Column("PRJ_TYPE")]
    [StringLength(50)]
    [Unicode(false)]
    public string PrjType { get; set; }

    [Column("CASE_WORKER")]
    [StringLength(50)]
    [Unicode(false)]
    public string CaseWorker { get; set; }

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

    [Column("FLAG_DELETED")]
    public bool FlagDeleted { get; set; }

    [Column("GOOGLE_MAP")]
    [StringLength(500)]
    public string GoogleMap { get; set; }

    /// <summary>
    /// Address
    /// </summary>
    [Column("ADDRESS")]
    [StringLength(500)]
    public string Address { get; set; }

    [Column("CUSTOMER_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string CustomerCode { get; set; }

    [Column("SUPPLIER_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string SupplierCode { get; set; }

    [Column("STATUS")]
    public string Status { get; set; }

    [Column("LIST_USER_VIEW")]
    public string ListUserView { get; set; }

    [Column("WORKFLOW_CAT")]
    [StringLength(255)]
    [Unicode(false)]
    public string WorkflowCat { get; set; }

    [Column("STATUS_OBJECT")]
    [StringLength(255)]
    public string StatusObject { get; set; }

    [Column("STATUS_OBJECT_LOG")]
    public string StatusObjectLog { get; set; }
}
