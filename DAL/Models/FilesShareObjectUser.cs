using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("FILES_SHARE_OBJECT_USER")]
public partial class FilesShareObjectUser
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("FILE_ID")]
    [StringLength(255)]
    [Unicode(false)]
    public string FileId { get; set; }

    [Column("OBJECT_RELATIVE")]
    public string ObjectRelative { get; set; }

    [Column("FILE_CREATED")]
    [StringLength(100)]
    [Unicode(false)]
    public string FileCreated { get; set; }

    [Column("CREATED_BY")]
    [StringLength(100)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(100)]
    [Unicode(false)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(100)]
    [Unicode(false)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("FILE_URL")]
    public string FileUrl { get; set; }

    [Column("FILE_NAME")]
    [StringLength(255)]
    public string FileName { get; set; }

    [Column("LIST_USER_SHARE")]
    public string ListUserShare { get; set; }
}
