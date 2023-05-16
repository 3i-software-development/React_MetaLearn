using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("ASSET_TRANSFER_HEADER")]
public partial class AssetTransferHeader
{
    [Key]
    [Column("ASSET_ID")]
    public int AssetId { get; set; }

    [Column("TICKETCODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string Ticketcode { get; set; }

    [Column("TICKET")]
    [StringLength(255)]
    public string Ticket { get; set; }

    [Column("DEPART_TRANSF")]
    [StringLength(255)]
    public string DepartTransf { get; set; }

    [Column("USER_TRANSF")]
    [StringLength(255)]
    public string UserTransf { get; set; }

    [Column("LOCATION_TRANSF")]
    [StringLength(255)]
    public string LocationTransf { get; set; }

    [Column("START_TIME")]
    public DateTime? StartTime { get; set; }

    [Column("DEPART_RECEIVED")]
    [StringLength(255)]
    public string DepartReceived { get; set; }

    [Column("USER_RECEIVED")]
    [StringLength(255)]
    public string UserReceived { get; set; }

    [Column("RECEIVED_TIME")]
    public DateTime? ReceivedTime { get; set; }

    [Column("RECEIVED_LOCATION")]
    [StringLength(255)]
    public string ReceivedLocation { get; set; }

    [Column("STATUS")]
    public string Status { get; set; }

    [Column("NOTE")]
    [StringLength(500)]
    public string Note { get; set; }

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

    [Column("LOG_STATUS")]
    public string LogStatus { get; set; }

    [Column("OBJ_ACT_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ObjActCode { get; set; }

    [Column("QRCODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string Qrcode { get; set; }

    [Column("WORKFLOW_CAT")]
    [StringLength(255)]
    [Unicode(false)]
    public string WorkflowCat { get; set; }
}
