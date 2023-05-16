using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("COIN_RATE_EXCHANGE")]
public partial class CoinRateExchange
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("MONEY")]
    [StringLength(100)]
    public string Money { get; set; }

    [Column("CURRENCY")]
    [StringLength(255)]
    public string Currency { get; set; }

    [Column("RATE", TypeName = "decimal(18, 5)")]
    public decimal? Rate { get; set; }

    [Column("TIME_UPDATED")]
    public DateTime? TimeUpdated { get; set; }
}
