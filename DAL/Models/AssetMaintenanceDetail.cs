using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("ASSET_MAINTENANCE_DETAILS")]
public partial class AssetMaintenanceDetail
{
    [Key]
    [Column("ASSET_ID")]
    public int AssetId { get; set; }

    [Column("ASSET_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string AssetCode { get; set; }

    [Column("TOTAL_MONEY")]
    public long? TotalMoney { get; set; }

    [Column("LIST_IMAGE")]
    [StringLength(255)]
    public string ListImage { get; set; }

    [Column("STATUS_ASSET")]
    [StringLength(255)]
    public string StatusAsset { get; set; }

    [Column("NOTE")]
    [StringLength(255)]
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

    [Column("DELETED_BY")]
    [StringLength(255)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("TICKET_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string TicketCode { get; set; }

    [Column("USER_ASSET")]
    [StringLength(100)]
    public string UserAsset { get; set; }

    [Column("ASSET_QUANTITY")]
    public int? AssetQuantity { get; set; }
}
