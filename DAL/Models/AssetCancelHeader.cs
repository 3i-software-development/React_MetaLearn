using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Model;

[Table("ASSET_CANCEL_HEADER")]
public partial class AssetCancelHeader
{
    [Key]
    [Column("ASSET_ID")]
    public int AssetId { get; set; }

    [Column("TICKET_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string TicketCode { get; set; }

    [Column("TITLE")]
    [StringLength(255)]
    public string Title { get; set; }

    [Column("BRANCH")]
    [StringLength(255)]
    [Unicode(false)]
    public string Branch { get; set; }

    [Column("PERSON")]
    [StringLength(255)]
    [Unicode(false)]
    public string Person { get; set; }

    [Column("NOTE")]
    [StringLength(500)]
    public string Note { get; set; }

    [Column("STATUS")]
    public string Status { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(255)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("DELETED_BY")]
    [StringLength(100)]
    [Unicode(false)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("CANCEL_TIME")]
    public DateTime? CancelTime { get; set; }

    [Column("ADRESS")]
    [StringLength(255)]
    public string Adress { get; set; }

    [Column("LOG_STATUS")]
    public string LogStatus { get; set; }

    [Column("OBJ_ACT_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ObjActCode { get; set; }

    [Column("WORKFLOW_CAT")]
    [StringLength(255)]
    [Unicode(false)]
    public string WorkflowCat { get; set; }
}
