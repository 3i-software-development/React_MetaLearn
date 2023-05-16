using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("CONTRACT_SERVICE_DETAIL_HIS")]
public partial class ContractServiceDetailHi
{
    /// <summary>
    /// Customer Id
    /// </summary>
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Required]
    [Column("SERVICE_CODE")]
    [StringLength(100)]
    public string ServiceCode { get; set; }

    [Column("SERVICE_NAME")]
    [StringLength(255)]
    public string ServiceName { get; set; }

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

    [Column("CURRENCY")]
    [StringLength(255)]
    public string Currency { get; set; }
}
