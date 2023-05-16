using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("LOT_PRODUCT_DETAIL")]
public partial class LotProductDetail
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("LOT_PRODUCT_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string LotProductCode { get; set; }

    [Column("PRODUCT_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ProductCode { get; set; }

    [Column("QUANTITY", TypeName = "decimal(18, 2)")]
    public decimal? Quantity { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(7)]
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

    [Column("COST", TypeName = "decimal(18, 2)")]
    public decimal? Cost { get; set; }

    [Column("TAX")]
    public int? Tax { get; set; }

    [Column("NOTE")]
    [StringLength(255)]
    public string Note { get; set; }

    [Column("BAR_CODE")]
    [StringLength(500)]
    [Unicode(false)]
    public string BarCode { get; set; }

    [Column("QR_CODE")]
    [StringLength(500)]
    [Unicode(false)]
    public string QrCode { get; set; }

    [Column("UNIT")]
    [StringLength(50)]
    public string Unit { get; set; }

    [Column("PRICE", TypeName = "decimal(18, 2)")]
    public decimal? Price { get; set; }

    [Column("DISCOUNT")]
    public int? Discount { get; set; }

    [Column("COMMISSION")]
    public int? Commission { get; set; }

    [Column("PRODUCT_TYPE")]
    [StringLength(50)]
    [Unicode(false)]
    public string ProductType { get; set; }
}
