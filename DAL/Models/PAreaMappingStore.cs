using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("P_AREA_MAPPING_STORE")]
public partial class PAreaMappingStore
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("OBJECT_CODE")]
    [StringLength(255)]
    public string ObjectCode { get; set; }

    [Column("OBJECT_TYPE")]
    [StringLength(255)]
    public string ObjectType { get; set; }

    [Column("CATEGORY_CODE")]
    [StringLength(255)]
    public string CategoryCode { get; set; }

    [Column("SVG_ICON_DATA")]
    [StringLength(255)]
    public string SvgIconData { get; set; }

    [Column("IMAGE")]
    [StringLength(255)]
    public string Image { get; set; }

    [Column("SHAPE_DATA")]
    public string ShapeData { get; set; }

    [Column("JSON_ATTR")]
    public string JsonAttr { get; set; }

    [Column("STATUS")]
    [StringLength(255)]
    public string Status { get; set; }

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
