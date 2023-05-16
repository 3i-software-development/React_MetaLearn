using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
public partial class VImpExpProduct
{
    [Column("ID")]
    public Guid? Id { get; set; }

    [Column("HEADER_CODE")]
    [StringLength(255)]
    public string HeaderCode { get; set; }

    [Column("HEADER_NAME")]
    [StringLength(255)]
    public string HeaderName { get; set; }

    [Column("PO_CODE")]
    [StringLength(255)]
    public string PoCode { get; set; }

    [Column("PO_NAME")]
    [StringLength(1000)]
    public string PoName { get; set; }

    [Required]
    [Column("STORE_CODE")]
    [StringLength(255)]
    public string StoreCode { get; set; }

    [Column("STORE_NAME")]
    [StringLength(255)]
    public string StoreName { get; set; }

    [Column("PRODUCT_CODE")]
    [StringLength(100)]
    public string ProductCode { get; set; }

    [Column("PRODUCT_QR_CODE")]
    [StringLength(255)]
    public string ProductQrCode { get; set; }

    [Column("QUANTITY")]
    public int? Quantity { get; set; }

    [Column("QUANTITY_NEED_IMP_EXP")]
    public int? QuantityNeedImpExp { get; set; }

    [Column("COST", TypeName = "decimal(18, 0)")]
    public decimal? Cost { get; set; }

    [Required]
    [Column("TYPE")]
    [StringLength(8)]
    [Unicode(false)]
    public string Type { get; set; }

    [Column("CUS_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string CusCode { get; set; }

    [Column("CUS_NAME")]
    [StringLength(255)]
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
    public string ProductType { get; set; }

    [Column("CREATED_TIME", TypeName = "datetime")]
    public DateTime? CreatedTime { get; set; }

    [Column("UNIT")]
    [StringLength(50)]
    public string Unit { get; set; }

    [Column("QUANTITY_IN_STORE")]
    public int? QuantityInStore { get; set; }

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

    [Column("TOTAL_QUANTITY_BY_STORE")]
    public int? TotalQuantityByStore { get; set; }

    [Column("TOTAL_QUANTITY_IN_STORE")]
    public int? TotalQuantityInStore { get; set; }
}
