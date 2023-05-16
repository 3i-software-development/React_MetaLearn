using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("PO_SALE_PRODUCT_DETAIL")]
public partial class PoSaleProductDetail
{
    /// <summary>
    /// Customer Id
    /// </summary>
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Required]
    [Column("PRODUCT_CODE")]
    [StringLength(100)]
    public string ProductCode { get; set; }

    [Column("PRODUCT_NAME")]
    [StringLength(255)]
    public string ProductName { get; set; }

    [Column("QUANTITY", TypeName = "decimal(18, 0)")]
    public decimal? Quantity { get; set; }

    [Column("UNIT")]
    [StringLength(50)]
    public string Unit { get; set; }

    [Column("COST", TypeName = "decimal(18, 0)")]
    public decimal? Cost { get; set; }

    [Column("CONTRACT_CODE")]
    [StringLength(100)]
    public string ContractCode { get; set; }

    [Column("CONTRACT_VERSION")]
    public int? ContractVersion { get; set; }

    [Column("NOTE")]
    [StringLength(500)]
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

    [Column("TAX")]
    public double? Tax { get; set; }

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

    [Column("QUANTITY_NEED_EXPORT", TypeName = "decimal(18, 0)")]
    public decimal? QuantityNeedExport { get; set; }
}
