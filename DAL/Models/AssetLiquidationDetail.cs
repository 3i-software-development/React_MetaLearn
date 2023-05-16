using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("ASSET_LIQUIDATION_DETAIL")]
public partial class AssetLiquidationDetail
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("ASSET_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string AssetCode { get; set; }

    [Column("TICKET_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string TicketCode { get; set; }

    [Column("QUANTITY")]
    public int? Quantity { get; set; }

    [Column("PRICE", TypeName = "decimal(18, 0)")]
    public decimal? Price { get; set; }

    [Column("TOTAL_MONEY", TypeName = "decimal(18, 0)")]
    public decimal? TotalMoney { get; set; }

    [Column("NOTE")]
    [StringLength(1000)]
    public string Note { get; set; }

    [Column("STATUS")]
    [StringLength(100)]
    public string Status { get; set; }

    [Column("CREATED_BY")]
    [StringLength(100)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(100)]
    [Unicode(false)]
    public string UpdatedBy { get; set; }

    [Column("DELETED_BY")]
    [StringLength(100)]
    [Unicode(false)]
    public string DeletedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("CURRENCY_ASSET")]
    [StringLength(50)]
    [Unicode(false)]
    public string CurrencyAsset { get; set; }
}
