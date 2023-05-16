using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("FILE_VERSION")]
public partial class FileVersion
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("FILE_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string FileCode { get; set; }

    [Column("URL")]
    [StringLength(255)]
    public string Url { get; set; }

    [Column("VERSION")]
    public int? Version { get; set; }

    [Column("OBJ_TYPE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ObjType { get; set; }

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

    [Column("OBJ_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ObjCode { get; set; }
}
