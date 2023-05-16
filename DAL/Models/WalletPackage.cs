using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Model;

[Keyless]
[Table("WALLET_PACKAGE")]
public partial class WalletPackage
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("PACKAGE_CODE")]
    [StringLength(255)]
    public string PackageCode { get; set; }

    [Column("PACKAGE_NAME")]
    [StringLength(255)]
    public string PackageName { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(1000)]
    public string Description { get; set; }

    [Column("CONDITION_JSON")]
    public string ConditionJson { get; set; }

    [Column("STATUS")]
    [StringLength(255)]
    public string Status { get; set; }

    [Column("DURATION", TypeName = "decimal(15, 0)")]
    public decimal? Duration { get; set; }

    [Column("DURATION_UNIT")]
    [StringLength(255)]
    public string DurationUnit { get; set; }

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
    public bool? IsDeleted { get; set; }
}
