using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("PROD_RECEIVED_DETAIL")]
public partial class ProdReceivedDetail
{
    /// <summary>
    /// Customer Id
    /// </summary>
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("TICKET_CODE")]
    [StringLength(255)]
    public string TicketCode { get; set; }

    [Column("LOT_PRODUCT_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string LotProductCode { get; set; }

    [Column("PRODUCT_CODE")]
    [StringLength(100)]
    public string ProductCode { get; set; }

    [Column("PRODUCT_QR_CODE")]
    [StringLength(255)]
    public string ProductQrCode { get; set; }

    [Column("QUANTITY", TypeName = "decimal(18, 2)")]
    public decimal? Quantity { get; set; }

    [Column("UNIT")]
    [StringLength(50)]
    public string Unit { get; set; }

    [Column("SALE_PRICE", TypeName = "decimal(18, 2)")]
    public decimal? SalePrice { get; set; }

    [Column("CURRENCY")]
    [StringLength(50)]
    public string Currency { get; set; }

    [Column("TAX_RATE")]
    public int? TaxRate { get; set; }

    [Column("DISCOUNT")]
    public int? Discount { get; set; }

    [Column("COMMISSION")]
    public int? Commission { get; set; }

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

    [Column("RACK_CODE")]
    [StringLength(255)]
    public string RackCode { get; set; }

    [Column("PRODUCT_TYPE")]
    [StringLength(50)]
    public string ProductType { get; set; }

    [Column("QUANTITY_IS_SET", TypeName = "decimal(18, 2)")]
    public decimal? QuantityIsSet { get; set; }

    [Column("PACK_TYPE")]
    [StringLength(255)]
    public string PackType { get; set; }

    [Column("PRODUCT_LOT")]
    [StringLength(255)]
    public string ProductLot { get; set; }

    [Column("CUS_CODE")]
    [StringLength(255)]
    public string CusCode { get; set; }

    [Column("PO_SUP_CODE")]
    [StringLength(255)]
    public string PoSupCode { get; set; }

    [Column("SECTION")]
    [StringLength(255)]
    public string Section { get; set; }

    [Column("QUANTITY_IMP")]
    public int? QuantityImp { get; set; }

    [Column("IS_INTACT")]
    public bool? IsIntact { get; set; }

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

    [Column("IS_INSIDE")]
    public bool? IsInside { get; set; }

    [Column("INSIDE_ORIGIN_MAP")]
    [StringLength(511)]
    public string InsideOriginMap { get; set; }

    [Column("INSIDE_ORIGIN_NO")]
    [StringLength(50)]
    [Unicode(false)]
    public string InsideOriginNo { get; set; }

    [Column("PROD_PARENT")]
    [StringLength(255)]
    public string ProdParent { get; set; }
}
