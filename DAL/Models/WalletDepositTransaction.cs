using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Model;

[Keyless]
[Table("WALLET_DEPOSIT_TRANSACTION")]
public partial class WalletDepositTransaction
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("TRANSACTION_CODE")]
    [StringLength(255)]
    public string TransactionCode { get; set; }

    [Column("TRANSACTION_TYPE")]
    [StringLength(255)]
    public string TransactionType { get; set; }

    [Column("TYPE")]
    [StringLength(255)]
    public string Type { get; set; }

    [Column("AMOUNT", TypeName = "decimal(18, 0)")]
    public decimal? Amount { get; set; }

    [Column("CURRENCY")]
    [StringLength(255)]
    public string Currency { get; set; }

    [Column("TRANSACTION_LOG")]
    public string TransactionLog { get; set; }

    [Column("STATUS")]
    [StringLength(255)]
    public string Status { get; set; }

    [Column("COIN", TypeName = "decimal(18, 0)")]
    public decimal? Coin { get; set; }

    [Column("IP", TypeName = "decimal(18, 0)")]
    public decimal? Ip { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATE_BY")]
    [StringLength(255)]
    public string UpdateBy { get; set; }

    [Column("UPDATE_TIME")]
    public DateTime? UpdateTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(255)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }
}
