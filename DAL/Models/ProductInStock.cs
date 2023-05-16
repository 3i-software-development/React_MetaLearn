using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("PRODUCT_IN_STOCK")]
public partial class ProductInStock
{
    /// <summary>
    /// Customer Id
    /// </summary>
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("LOT_PRODUCT_CODE")]
    [StringLength(100)]
    public string LotProductCode { get; set; }

    [Column("PRODUCT_CODE")]
    [StringLength(100)]
    public string ProductCode { get; set; }

    [Column("PRODUCT_QR_CODE")]
    [StringLength(100)]
    public string ProductQrCode { get; set; }

    [Column("QUANTITY", TypeName = "decimal(18, 2)")]
    public decimal? Quantity { get; set; }

    [Column("UNIT")]
    [StringLength(50)]
    public string Unit { get; set; }

    [Column("STORE_CODE")]
    [StringLength(100)]
    public string StoreCode { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime CreatedTime { get; set; }

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

    [Column("PRODUCT_TYPE")]
    [StringLength(50)]
    public string ProductType { get; set; }

    [Column("MARK_WHOLE_PRODUCT")]
    public bool? MarkWholeProduct { get; set; }

    [Column("PACK_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string PackCode { get; set; }

    [Column("PROD_CUSTOM_JSON")]
    public string ProdCustomJson { get; set; }

    [Column("IS_CUSTOMIZED")]
    public bool? IsCustomized { get; set; }

    [Column("PRODUCT_NO")]
    public string ProductNo { get; set; }

    [Column("PROD_ATTR_GROUP")]
    [StringLength(255)]
    public string ProdAttrGroup { get; set; }
}
