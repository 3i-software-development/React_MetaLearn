using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("MAP_DATA_GPS")]
public partial class MapDataGp
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("MAP_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string MapCode { get; set; }

    [Column("MAKER_GPS")]
    [StringLength(255)]
    public string MakerGps { get; set; }

    [Column("POLYGON_GPS")]
    public string PolygonGps { get; set; }

    [Column("TITLE")]
    [StringLength(255)]
    public string Title { get; set; }

    [Column("ICON")]
    [StringLength(255)]
    public string Icon { get; set; }

    [Column("OBJ_TYPE")]
    [StringLength(255)]
    public string ObjType { get; set; }

    [Column("OBJ_CODE")]
    [StringLength(255)]
    public string ObjCode { get; set; }

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

    [Column("IMAGE")]
    [StringLength(255)]
    [Unicode(false)]
    public string Image { get; set; }

    [Column("IS_ACTIVE")]
    public bool? IsActive { get; set; }

    [Column("IS_DEFAULT")]
    public bool? IsDefault { get; set; }

    [Column("GIS_DATA")]
    public string GisData { get; set; }

    [Column("ADDRESS")]
    [StringLength(500)]
    public string Address { get; set; }
}
