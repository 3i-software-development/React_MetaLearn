using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("EDMS_FILE_PACK_COVER")]
public partial class EdmsFilePackCover
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("FILE_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string FileCode { get; set; }

    [Column("OBJ_PACK_CODE")]
    [StringLength(100)]
    public string ObjPackCode { get; set; }

    [Column("RACK_CODE")]
    [StringLength(100)]
    public string RackCode { get; set; }

    [Column("RACK_POSITION")]
    [StringLength(100)]
    public string RackPosition { get; set; }

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
}
