using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("ASSET_RPT_BROKEN_DETAILS")]
public partial class AssetRptBrokenDetail
{
    [Key]
    [Column("ASSET_ID")]
    public int AssetId { get; set; }

    [Column("ASSET_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string AssetCode { get; set; }

    [Column("ASSET_NAME")]
    [StringLength(255)]
    public string AssetName { get; set; }

    [Column("QUANTITY")]
    public int? Quantity { get; set; }

    [Column("NOTE")]
    [StringLength(500)]
    public string Note { get; set; }

    [Column("ASSET_STATUS")]
    [StringLength(255)]
    public string AssetStatus { get; set; }

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
    [StringLength(255)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("TICKET_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string TicketCode { get; set; }
}
