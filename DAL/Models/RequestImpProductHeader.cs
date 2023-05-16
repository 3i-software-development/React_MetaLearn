using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("REQUEST_IMP_PRODUCT_HEADER")]
public partial class RequestImpProductHeader
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("REQ_CODE")]
    [StringLength(255)]
    public string ReqCode { get; set; }

    [Column("TITLE")]
    [StringLength(255)]
    public string Title { get; set; }

    [Column("PO_CODE")]
    [StringLength(255)]
    public string PoCode { get; set; }

    [Column("STATUS")]
    public string Status { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("APPROVED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string ApprovedBy { get; set; }

    [Column("APPROVED_TIME")]
    public DateTime? ApprovedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("CUS_CODE")]
    [StringLength(255)]
    public string CusCode { get; set; }

    [Column("PROJECT_CODE")]
    [StringLength(255)]
    public string ProjectCode { get; set; }

    [Column("WORKFLOW_CAT")]
    [StringLength(255)]
    [Unicode(false)]
    public string WorkflowCat { get; set; }

    [Column("JSON_DATA")]
    public string JsonData { get; set; }

    [Column("STATUS_OBJECT")]
    [StringLength(255)]
    public string StatusObject { get; set; }

    [Column("STATUS_OBJECT_LOG")]
    public string StatusObjectLog { get; set; }

    [Column("LOG_DATA")]
    public string LogData { get; set; }

    [Column("LOG_PRODUCT_DETAIL")]
    public string LogProductDetail { get; set; }
}
