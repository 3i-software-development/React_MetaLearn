using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
public partial class VReportStaticsPoCu
{
    [Column("ID")]
    public int Id { get; set; }

    [Required]
    [Column("PRODUCT_CODE")]
    [StringLength(100)]
    public string ProductCode { get; set; }

    [Column("PRODUCT_TYPE")]
    [StringLength(50)]
    [Unicode(false)]
    public string ProductType { get; set; }

    [Column("REVENUE_AFTER_TAX_VND")]
    public double? RevenueAfterTaxVnd { get; set; }

    [Column("CONTRACT_CODE")]
    [StringLength(100)]
    public string ContractCode { get; set; }

    [Column("TITLE")]
    [StringLength(1000)]
    public string Title { get; set; }

    [Column("EFFECTIVE_DATE")]
    public DateTime? EffectiveDate { get; set; }

    [Column("CONTRACT_NO")]
    [StringLength(100)]
    public string ContractNo { get; set; }

    [Column("CUS_CODE")]
    [StringLength(100)]
    public string CusCode { get; set; }

    [Column("EXCHANGE_RATE", TypeName = "decimal(18, 2)")]
    public decimal? ExchangeRate { get; set; }

    [Column("CUS_NAME")]
    [StringLength(255)]
    public string CusName { get; set; }
}
