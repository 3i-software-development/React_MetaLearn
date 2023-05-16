using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("FORECAST_PRODUCT_IN_STOCK")]
public partial class ForecastProductInStock
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("PRODUCT_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ProductCode { get; set; }

    [Column("CNT_PRODUCT_IN_STOCK")]
    public int? CntProductInStock { get; set; }

    [Column("CNT_FORECAST")]
    public int? CntForecast { get; set; }

    [Column("FORECAST_DATE", TypeName = "date")]
    public DateTime? ForecastDate { get; set; }

    [Column("PRODUCT_TYPE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ProductType { get; set; }

    [Column("CNT")]
    public int? Cnt { get; set; }

    [Column("CNT_2")]
    public int? Cnt2 { get; set; }
}
