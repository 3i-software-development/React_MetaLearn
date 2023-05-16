using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("ASSET_IMPROVEMENT_HEADER")]
public partial class AssetImprovementHeader
{
    [Key]
    [Column("TICKET_ID")]
    public int TicketId { get; set; }

    [Column("TICKET_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string TicketCode { get; set; }

    [Column("TITLE")]
    [StringLength(255)]
    public string Title { get; set; }

    [Column("BRANCH")]
    [StringLength(255)]
    public string Branch { get; set; }

    [Column("DEPART_TRANSFER")]
    [StringLength(255)]
    public string DepartTransfer { get; set; }

    [Column("USER_TRANSFER")]
    [StringLength(255)]
    public string UserTransfer { get; set; }

    [Column("START_TIME")]
    public DateTime? StartTime { get; set; }

    [Column("LOCATION_TRANSFER")]
    [StringLength(255)]
    public string LocationTransfer { get; set; }

    [Column("UNIT_MAINTENANCE")]
    [StringLength(255)]
    public string UnitMaintenance { get; set; }

    [Column("RECEIVED_TIME")]
    public DateTime? ReceivedTime { get; set; }

    [Column("LOCATION_RECEIVED")]
    [StringLength(255)]
    public string LocationReceived { get; set; }

    [Column("STATUS")]
    public string Status { get; set; }

    [Column("LOG_STATUS")]
    public string LogStatus { get; set; }

    [Column("NOTE")]
    [StringLength(500)]
    public string Note { get; set; }

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
    public bool? IsDeleted { get; set; }

    [Column("OBJ_ACT_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ObjActCode { get; set; }

    [Column("TOTAL_MONEY")]
    public int? TotalMoney { get; set; }

    [Column("CURRENCY")]
    [StringLength(50)]
    [Unicode(false)]
    public string Currency { get; set; }

    [Column("WORKFLOW_CAT")]
    [StringLength(255)]
    [Unicode(false)]
    public string WorkflowCat { get; set; }
}
