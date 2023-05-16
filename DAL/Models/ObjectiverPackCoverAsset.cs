using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("OBJECTIVER_PACK_COVER_ASSET")]
public partial class ObjectiverPackCoverAsset
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("OBJ_PACK_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ObjPackCode { get; set; }

    [Column("NAME")]
    [StringLength(100)]
    public string Name { get; set; }

    [Column("SPEC_SIZE")]
    [StringLength(100)]
    public string SpecSize { get; set; }

    [Column("WEIGHT")]
    [StringLength(100)]
    public string Weight { get; set; }

    [Column("UNIT")]
    [StringLength(100)]
    public string Unit { get; set; }

    [Column("LOCATED")]
    [StringLength(100)]
    [Unicode(false)]
    public string Located { get; set; }

    [Column("PARENT_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ParentCode { get; set; }

    [Column("DESCRIPTION")]
    public string Description { get; set; }

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

    [Column("SHAPE_DATA")]
    public string ShapeData { get; set; }
}
