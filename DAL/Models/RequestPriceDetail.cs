using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("REQUEST_PRICE_DETAIL")]
public partial class RequestPriceDetail
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

    [Column("QUANTITY", TypeName = "decimal(18, 0)")]
    public decimal? Quantity { get; set; }

    [Column("PRICE", TypeName = "decimal(18, 0)")]
    public decimal? Price { get; set; }

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
    [StringLength(255)]
    public string ProductType { get; set; }

    [Column("TOTAL", TypeName = "decimal(18, 2)")]
    public decimal? Total { get; set; }

    [Column("SUP_CODE")]
    [StringLength(255)]
    public string SupCode { get; set; }

    [Column("NOTE")]
    public string Note { get; set; }
}
