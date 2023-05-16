using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("FUND_CURRENCY")]
public partial class FundCurrency
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Required]
    [Column("CURRENCY_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string CurrencyCode { get; set; }

    [Column("DEFAULT_PAYMENT")]
    public bool? DefaultPayment { get; set; }

    [Column("NOTE")]
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
    public bool IsDeleted { get; set; }

    [Column("CONVERSION_RATE", TypeName = "decimal(14, 5)")]
    public decimal? ConversionRate { get; set; }
}
