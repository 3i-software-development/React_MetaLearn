using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("REQUEST_IMP_PRODUCT_DETAIL")]
public partial class RequestImpProductDetail
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("REQ_CODE")]
    [StringLength(255)]
    public string ReqCode { get; set; }

    [Column("PRODUCT_CODE")]
    [StringLength(255)]
    public string ProductCode { get; set; }

    [Column("PO_COUNT")]
    [StringLength(255)]
    [Unicode(false)]
    public string PoCount { get; set; }

    [Column("RATE_CONVERSION", TypeName = "decimal(18, 2)")]
    public decimal? RateConversion { get; set; }

    [Column("RATE_LOSS", TypeName = "decimal(18, 2)")]
    public decimal? RateLoss { get; set; }

    [Column("QUANTITY", TypeName = "decimal(18, 0)")]
    public decimal? Quantity { get; set; }

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

    [Column("UNIT")]
    [StringLength(50)]
    public string Unit { get; set; }

    [Column("PRODUCT_TYPE")]
    [StringLength(255)]
    public string ProductType { get; set; }

    [Column("SUP_CODE")]
    [StringLength(255)]
    public string SupCode { get; set; }

    [Column("EXPECTED_DATE")]
    public DateTime? ExpectedDate { get; set; }
}
