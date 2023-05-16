using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("ASSET_LIQUIDATION_HEADER")]
public partial class AssetLiquidationHeader
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("TICKET_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string TicketCode { get; set; }

    [Column("TITLE")]
    [StringLength(255)]
    public string Title { get; set; }

    [Column("BRANCH_LIQUIDATION")]
    [StringLength(255)]
    public string BranchLiquidation { get; set; }

    [Column("LIQUIDATION_TIME")]
    public DateTime? LiquidationTime { get; set; }

    [Column("USER_LIQUIDATION")]
    [StringLength(50)]
    public string UserLiquidation { get; set; }

    [Column("LOCATION_LIQUIDATION")]
    [StringLength(255)]
    public string LocationLiquidation { get; set; }

    [Column("STATUS")]
    public string Status { get; set; }

    [Column("LOG_STATUS")]
    public string LogStatus { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(1000)]
    public string Description { get; set; }

    [Column("USER_BUY")]
    [StringLength(50)]
    public string UserBuy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("CREATED_BY")]
    [StringLength(100)]
    public string CreatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(100)]
    public string UpdatedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(100)]
    public string DeletedBy { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("OBJ_ACT_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ObjActCode { get; set; }

    [Column("WORKFLOW_CAT")]
    [StringLength(255)]
    [Unicode(false)]
    public string WorkflowCat { get; set; }
}
