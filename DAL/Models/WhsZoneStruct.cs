using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("WHS_ZONE_STRUCT")]
public partial class WhsZoneStruct
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("ZONE_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string ZoneCode { get; set; }

    [Column("ZONE_NAME")]
    [StringLength(255)]
    public string ZoneName { get; set; }

    [Column("ZONE_LABEL")]
    [StringLength(255)]
    public string ZoneLabel { get; set; }

    [Column("ZONE_LEVEL")]
    public int? ZoneLevel { get; set; }

    [Column("ZONE_PARENT")]
    [StringLength(50)]
    [Unicode(false)]
    public string ZoneParent { get; set; }

    [Column("ZONE_HIERACHY")]
    [StringLength(255)]
    public string ZoneHierachy { get; set; }

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

    [Column("SVG_ICON_DATA")]
    [StringLength(255)]
    public string SvgIconData { get; set; }

    [Column("IMAGE")]
    [StringLength(255)]
    public string Image { get; set; }

    [Column("SHAPE_DATA")]
    public string ShapeData { get; set; }
}
