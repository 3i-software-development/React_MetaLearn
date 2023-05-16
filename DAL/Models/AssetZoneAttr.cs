using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("ASSET_ZONE_ATTR")]
public partial class AssetZoneAttr
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("ZONE_ATTR_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string ZoneAttrCode { get; set; }

    [Column("ZONE_ATTR_NAME")]
    [StringLength(255)]
    public string ZoneAttrName { get; set; }

    [Column("ZONE_ATTR_VALUE")]
    [StringLength(255)]
    public string ZoneAttrValue { get; set; }

    [Column("ZONE_ATTR_UNIT")]
    [StringLength(255)]
    public string ZoneAttrUnit { get; set; }

    [Column("ZONE_ATTR_TYPE")]
    [StringLength(255)]
    public string ZoneAttrType { get; set; }

    [Column("ZONE_ATTR_SIZE")]
    [StringLength(50)]
    public string ZoneAttrSize { get; set; }

    [Column("ZONE_TYPE")]
    [StringLength(255)]
    public string ZoneType { get; set; }

    [Column("ZONE_GROUP")]
    [StringLength(255)]
    public string ZoneGroup { get; set; }

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

    [Column("SVG_ICON")]
    [StringLength(255)]
    public string SvgIcon { get; set; }

    [Column("IMAGE")]
    [StringLength(255)]
    public string Image { get; set; }
}
