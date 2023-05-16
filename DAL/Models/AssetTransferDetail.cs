using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("ASSET_TRANSFER_DETAILS")]
public partial class AssetTransferDetail
{
    [Key]
    [Column("ASSET_ID")]
    public int AssetId { get; set; }

    [Column("ASSET_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string AssetCode { get; set; }

    [Column("QUANTITY")]
    public int? Quantity { get; set; }

    [Column("COST_VALUE")]
    [StringLength(255)]
    [Unicode(false)]
    public string CostValue { get; set; }

    [Column("LIST_IMAGE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ListImage { get; set; }

    [Column("STATUS_ASSET")]
    [StringLength(255)]
    public string StatusAsset { get; set; }

    [Column("NOTE")]
    [StringLength(255)]
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

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("ASSET_NAME")]
    [StringLength(255)]
    public string AssetName { get; set; }

    [Column("TICKETCODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string Ticketcode { get; set; }

    [Column("DELETED_BY")]
    [StringLength(50)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }
}
