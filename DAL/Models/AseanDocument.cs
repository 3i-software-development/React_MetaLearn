using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("ASEAN_DOCUMENT")]
public partial class AseanDocument
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("FILE_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string FileCode { get; set; }

    [Column("TITLE")]
    [StringLength(255)]
    public string Title { get; set; }

    [Column("SUBDESC")]
    [StringLength(255)]
    public string Subdesc { get; set; }

    [Column("FILE_TYPE")]
    [StringLength(255)]
    [Unicode(false)]
    public string FileType { get; set; }

    [Column("VERSION")]
    public int? Version { get; set; }

    [Column("FILE_NAME")]
    [StringLength(255)]
    public string FileName { get; set; }

    [Column("FILE_SITE")]
    [StringLength(255)]
    public string FileSite { get; set; }

    [Column("FILE_PATH")]
    [StringLength(255)]
    public string FilePath { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(255)]
    public string Description { get; set; }

    [Column("PARENT_ID")]
    public int? ParentId { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(255)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("DELETED_BY")]
    [StringLength(255)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("CATE_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string CateCode { get; set; }

    [Column("FULL_PATH_VIEW")]
    [StringLength(500)]
    public string FullPathView { get; set; }

    [Column("IS_EDITED")]
    public bool? IsEdited { get; set; }

    [Column("VIEW_PATH")]
    [StringLength(255)]
    [Unicode(false)]
    public string ViewPath { get; set; }
}
