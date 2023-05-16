using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
public partial class VReportStaticsPoSup
{
    [Column("ID")]
    public Guid? Id { get; set; }

    [Required]
    [Column("HEADER_CODE")]
    [StringLength(1)]
    [Unicode(false)]
    public string HeaderCode { get; set; }

    [Required]
    [Column("HEADER_NAME")]
    [StringLength(1)]
    [Unicode(false)]
    public string HeaderName { get; set; }

    [Column("PO_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string PoCode { get; set; }

    [Column("PO_NAME")]
    [StringLength(255)]
    [Unicode(false)]
    public string PoName { get; set; }

    [Column("PRODUCT_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ProductCode { get; set; }

    [Column("QUANTITY")]
    public int? Quantity { get; set; }

    [Column("QUANTITY_NEED_IMP_EXP")]
    public int? QuantityNeedImpExp { get; set; }

    [Column("COST", TypeName = "decimal(18, 0)")]
    public decimal? Cost { get; set; }

    [Required]
    [Column("TYPE")]
    [StringLength(6)]
    [Unicode(false)]
    public string Type { get; set; }

    [Required]
    [Column("CUS_CODE")]
    [StringLength(1)]
    [Unicode(false)]
    public string CusCode { get; set; }

    [Required]
    [Column("CUS_NAME")]
    [StringLength(1)]
    [Unicode(false)]
    public string CusName { get; set; }

    [Column("SUP_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string SupCode { get; set; }

    [Column("SUP_NAME")]
    [StringLength(255)]
    public string SupName { get; set; }

    [Column("PRODUCT_TYPE")]
    [StringLength(50)]
    [Unicode(false)]
    public string ProductType { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UNIT")]
    [StringLength(255)]
    [Unicode(false)]
    public string Unit { get; set; }

    [Column("TOTAL", TypeName = "decimal(29, 0)")]
    public decimal? Total { get; set; }

    [Column("UNIT_NAME")]
    [StringLength(255)]
    public string UnitName { get; set; }

    [Column("PRODUCT_NAME")]
    [StringLength(30)]
    public string ProductName { get; set; }

    [Column("CATEGORY")]
    [StringLength(30)]
    public string Category { get; set; }

    [Required]
    [Column("CATEGORY_NAME")]
    [StringLength(1)]
    [Unicode(false)]
    public string CategoryName { get; set; }
}
