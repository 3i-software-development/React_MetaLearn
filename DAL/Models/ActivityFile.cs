using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("ACTIVITY_FILE")]
public partial class ActivityFile
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("ACTIVITY_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ActivityCode { get; set; }

    [Column("FILE_ID")]
    [StringLength(255)]
    public string FileId { get; set; }

    [Column("FILE_NAME")]
    [StringLength(255)]
    public string FileName { get; set; }

    [Column("FILE_PATH")]
    [StringLength(255)]
    public string FilePath { get; set; }

    [Column("FILE_TYPE")]
    [StringLength(255)]
    public string FileType { get; set; }

    [Column("FILE_SIZE", TypeName = "decimal(18, 0)")]
    public decimal? FileSize { get; set; }

    [Column("CREATED_BY")]
    [StringLength(100)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(100)]
    [Unicode(false)]
    public string UpdatedBy { get; set; }

    [Column("DELETED_BY")]
    [StringLength(100)]
    [Unicode(false)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }
}
