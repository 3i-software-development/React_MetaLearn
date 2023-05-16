using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Model;

[Keyless]
[Table("WALLET_COIN_TRANSACTION")]
public partial class WalletCoinTransaction
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("TRANSACTION_CODE")]
    [StringLength(255)]
    public string TransactionCode { get; set; }

    [Column("COIN", TypeName = "decimal(18, 0)")]
    public decimal? Coin { get; set; }

    [Column("ITEM_TYPE")]
    [StringLength(255)]
    public string ItemType { get; set; }

    [Column("ITEM_CODE")]
    [StringLength(255)]
    public string ItemCode { get; set; }

    [Column("TRANSACTION_COIN_LOG")]
    public string TransactionCoinLog { get; set; }

    [Column("STATUS")]
    [StringLength(255)]
    public string Status { get; set; }

    [Column("BUYER")]
    [StringLength(255)]
    public string Buyer { get; set; }

    [Column("SELLER")]
    [StringLength(255)]
    public string Seller { get; set; }

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
}
