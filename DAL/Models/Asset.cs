using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("ASSET")]
public partial class Asset
{
    [Column("ASSET_CODE")]
    [StringLength(100)]
    public string AssetCode { get; set; }

    [Column("ASSET_NAME")]
    [StringLength(255)]
    public string AssetName { get; set; }

    [Column("ASSET_TYPE")]
    [StringLength(255)]
    public string AssetType { get; set; }

    [Column("ASSET_GROUP")]
    [StringLength(255)]
    public string AssetGroup { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(255)]
    public string Description { get; set; }

    [Column("PATH_IMG")]
    [StringLength(255)]
    public string PathImg { get; set; }

    [Column("STATUS")]
    [StringLength(100)]
    public string Status { get; set; }

    [Column("BUYED_TIME")]
    public DateTime? BuyedTime { get; set; }

    [Column("EXPIRED_DATE")]
    public DateTime? ExpiredDate { get; set; }

    [Column("COST")]
    [StringLength(255)]
    public string Cost { get; set; }

    [Column("CURRENCY")]
    [StringLength(255)]
    public string Currency { get; set; }

    [Column("SUPPLIER_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string SupplierCode { get; set; }

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

    [Key]
    [Column("ASSET_ID")]
    public int AssetId { get; set; }

    [Column("LOCATION_TEXT")]
    [StringLength(500)]
    public string LocationText { get; set; }

    [Column("LOCATION_GPS")]
    [StringLength(255)]
    [Unicode(false)]
    public string LocationGps { get; set; }
}
