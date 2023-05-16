using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("WALLET_COIN_EXCHANGE")]
public partial class WalletCoinExchange
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("MONEY")]
    [StringLength(255)]
    public string Money { get; set; }

    [Column("CURRENCY")]
    [StringLength(255)]
    public string Currency { get; set; }

    [Column("COIN")]
    [StringLength(255)]
    public string Coin { get; set; }

    [Column("EXCHANGE_LOG")]
    public string ExchangeLog { get; set; }

    [Column("STATUS")]
    [StringLength(255)]
    public string Status { get; set; }

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
