using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("PRODUCT_QR_CODE")]
public partial class ProductQrCode
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("PRODUCT_CODE")]
    [StringLength(255)]
    public string ProductCode { get; set; }

    [Column("LOT_CODE")]
    [StringLength(255)]
    public string LotCode { get; set; }

    [Column("IMP_CODE")]
    [StringLength(255)]
    public string ImpCode { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    public string CreatedBy { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(255)]
    public string UpdatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("COUNT")]
    public int Count { get; set; }

    [Column("QR_CODE")]
    [StringLength(500)]
    [Unicode(false)]
    public string QrCode { get; set; }

    /// <summary>
    /// SP hay SP trong kho(lô, phiếu nhập)
    /// </summary>
    [Column("TYPE")]
    [StringLength(255)]
    [Unicode(false)]
    public string Type { get; set; }
}
