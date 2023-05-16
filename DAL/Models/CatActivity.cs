using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("CAT_ACTIVITY")]
public partial class CatActivity
{
    [Column("ACT_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ActCode { get; set; }

    [Column("ACT_NAME")]
    [StringLength(255)]
    public string ActName { get; set; }

    [Column("NOTE")]
    [StringLength(1000)]
    public string Note { get; set; }

    [Column("CREATED_BY")]
    [StringLength(100)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(100)]
    public string UpdatedBy { get; set; }

    [Column("DELETED_BY")]
    [StringLength(100)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("ACT_TYPE")]
    [StringLength(100)]
    public string ActType { get; set; }

    [Column("ACT_GROUP")]
    [StringLength(100)]
    public string ActGroup { get; set; }

    [Column("FILE_URL")]
    [StringLength(255)]
    public string FileUrl { get; set; }

    [Column("ID_MAPPING")]
    public int? IdMapping { get; set; }

    [Column("FILE_NAME")]
    [StringLength(255)]
    public string FileName { get; set; }
}
