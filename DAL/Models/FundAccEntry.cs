using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("FUND_ACC_ENTRY")]
public partial class FundAccEntry
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Required]
    [Column("AET_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string AetCode { get; set; }

    [Column("TITLE")]
    [StringLength(255)]
    public string Title { get; set; }

    [Column("AET_TYPE")]
    [StringLength(255)]
    public string AetType { get; set; }

    [Column("AET_DESCRIPTION")]
    [StringLength(255)]
    public string AetDescription { get; set; }

    [Column("IS_PLAN")]
    public bool? IsPlan { get; set; }

    [Column("CAT_CODE")]
    [StringLength(100)]
    public string CatCode { get; set; }

    [Column("DEAD_LINE")]
    public DateTime? DeadLine { get; set; }

    [Column("AET_RELATIVE")]
    [StringLength(255)]
    public string AetRelative { get; set; }

    [Column("AET_RELATIVE_TYPE")]
    [StringLength(255)]
    public string AetRelativeType { get; set; }

    [Column("PAYER")]
    [StringLength(255)]
    public string Payer { get; set; }

    [Column("RECEIPTTER")]
    [StringLength(255)]
    public string Receiptter { get; set; }

    [Column("TOTAL", TypeName = "decimal(18, 0)")]
    public decimal? Total { get; set; }

    [Column("CURRENCY")]
    [StringLength(100)]
    public string Currency { get; set; }

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

    [Column("GOOGLE_MAP")]
    [StringLength(255)]
    public string GoogleMap { get; set; }

    [Column("ADDRESS")]
    [StringLength(255)]
    public string Address { get; set; }

    /// <summary>
    /// CREATED,CANCEL,PENDING,REFUSE,ACCEPT
    /// </summary>
    [Column("STATUS")]
    public string Status { get; set; }

    [Column("LOG_DATA")]
    public string LogData { get; set; }

    [Column("IS_COMPLETED")]
    public bool? IsCompleted { get; set; }

    [Column("OBJ_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ObjCode { get; set; }

    [Column("OBJ_TYPE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ObjType { get; set; }

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
