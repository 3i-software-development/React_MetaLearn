using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("PROJECT_PRODUCT")]
public partial class ProjectProduct
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("PRODUCT_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ProductCode { get; set; }

    [Column("QUANTITY", TypeName = "decimal(18, 2)")]
    public decimal? Quantity { get; set; }

    [Column("UNIT")]
    [StringLength(255)]
    [Unicode(false)]
    public string Unit { get; set; }

    [Column("PROJECT_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ProjectCode { get; set; }

    [Column("COST", TypeName = "decimal(18, 0)")]
    public decimal Cost { get; set; }

    [Column("TAX")]
    public double Tax { get; set; }

    [Column("COMMISSION")]
    public double? Commission { get; set; }

    /// <summary>
    /// CHIẾT KHẤU
    /// </summary>
    [Column("CUSTOM_FEE")]
    public double? CustomFee { get; set; }

    /// <summary>
    /// GIẢM GIÁ
    /// </summary>
    [Column("DISCOUNT")]
    public double? Discount { get; set; }

    [Column("PRICE_TYPE")]
    [StringLength(255)]
    public string PriceType { get; set; }

    [Column("PRODUCT_TYPE")]
    [StringLength(50)]
    [Unicode(false)]
    public string ProductType { get; set; }

    [Column("QUANTITY_NEED_EXPORT", TypeName = "decimal(18, 2)")]
    public decimal? QuantityNeedExport { get; set; }

    [Column("NOTE")]
    [StringLength(500)]
    public string Note { get; set; }

    [Column("PORT_TYPE")]
    [StringLength(255)]
    public string PortType { get; set; }

    [Column("STATUS_OBJECT_LOG")]
    public string StatusObjectLog { get; set; }
}
