using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("FACO_PRODUCT_CAT")]
public partial class FacoProductCat
{
    /// <summary>
    /// Customer Id
    /// </summary>
    [Key]
    [Column("PRODUCT_ID")]
    public int ProductId { get; set; }

    [Column("PRODUCT_CODE")]
    [StringLength(100)]
    public string ProductCode { get; set; }

    [Column("PRODUCT_NAME")]
    [StringLength(255)]
    public string ProductName { get; set; }

    [Column("UNIT")]
    [StringLength(50)]
    public string Unit { get; set; }

    [Column("PATH_IMG")]
    [StringLength(500)]
    public string PathImg { get; set; }

    [Column("NOTE")]
    [StringLength(500)]
    public string Note { get; set; }

    [Column("PRODUCT_GROUP")]
    [StringLength(100)]
    public string ProductGroup { get; set; }

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

    [Column("DELETED_By")]
    [StringLength(50)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }

    [Column("COLOR")]
    [StringLength(20)]
    public string Color { get; set; }

    [Column("TRADE_MARK")]
    [StringLength(255)]
    public string TradeMark { get; set; }

    [Column("ORIGIN")]
    [StringLength(255)]
    public string Origin { get; set; }

    [Column("MATERIAL")]
    [StringLength(255)]
    public string Material { get; set; }

    [Column("USER_MANUAL")]
    [StringLength(255)]
    public string UserManual { get; set; }

    [Column("COST")]
    public double? Cost { get; set; }
}
