using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("PO_BUYER_DETAIL")]
public partial class PoBuyerDetail
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("PO_SUP_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string PoSupCode { get; set; }

    [Column("PRODUCT_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ProductCode { get; set; }

    [Column("QUANTITY")]
    [StringLength(255)]
    [Unicode(false)]
    public string Quantity { get; set; }

    [Column("UNIT")]
    [StringLength(255)]
    [Unicode(false)]
    public string Unit { get; set; }

    [Column("UNIT_PRICE", TypeName = "decimal(18, 0)")]
    public decimal? UnitPrice { get; set; }

    [Column("TOTAL_AMOUNT", TypeName = "decimal(18, 0)")]
    public decimal? TotalAmount { get; set; }

    [Column("NOTE")]
    [StringLength(255)]
    public string Note { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("PRODUCT_TYPE")]
    [StringLength(50)]
    [Unicode(false)]
    public string ProductType { get; set; }

    [Column("CURRENCY")]
    [StringLength(50)]
    public string Currency { get; set; }

    [Column("QUANTITY_NEED_IMPORT", TypeName = "decimal(18, 2)")]
    public decimal? QuantityNeedImport { get; set; }

    [Column("PO_COUNT")]
    [StringLength(255)]
    [Unicode(false)]
    public string PoCount { get; set; }

    [Column("RATE_CONVERSION", TypeName = "decimal(18, 2)")]
    public decimal? RateConversion { get; set; }

    [Column("RATE_LOSS", TypeName = "decimal(18, 2)")]
    public decimal? RateLoss { get; set; }

    [Column("SUP_CODE")]
    [StringLength(255)]
    public string SupCode { get; set; }

    [Column("EXPECTED_DATE")]
    public DateTime? ExpectedDate { get; set; }

    [Column("TYPE")]
    [StringLength(255)]
    public string Type { get; set; }

    [Column("REQ_CODE")]
    [StringLength(255)]
    public string ReqCode { get; set; }
}
