using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("ACTIVITY_INST_FILE")]
public partial class ActivityInstFile
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("ACTIVITY_INST_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ActivityInstCode { get; set; }

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

    [Column("PARENT_FILE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ParentFile { get; set; }

    [Column("IS_SIGN")]
    public bool? IsSign { get; set; }

    [Column("LST_USER_SIGN")]
    public string LstUserSign { get; set; }

    [Column("SIGNATURE_REQUIRE")]
    public bool? SignatureRequire { get; set; }

    [Column("SIGNATURE_JSON")]
    public string SignatureJson { get; set; }
}
