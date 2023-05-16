using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("VC_JNANA_FILE")]
public partial class VcJnanaFile
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("FILE_CODE")]
    [StringLength(255)]
    public string FileCode { get; set; }

    [Column("FILE_NAME")]
    [StringLength(255)]
    public string FileName { get; set; }

    [Column("FILE_TITLE")]
    [StringLength(255)]
    public string FileTitle { get; set; }

    [Column("FILE_NOTE")]
    [StringLength(255)]
    public string FileNote { get; set; }

    [Column("FILE_SIZE")]
    public double? FileSize { get; set; }

    [Column("FILE_EXT")]
    [StringLength(10)]
    [Unicode(false)]
    public string FileExt { get; set; }

    [Column("CREATED_BY")]
    public int? CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("FILE_STATUS")]
    public int? FileStatus { get; set; }

    [Column("FILE_CAT_CODE")]
    [StringLength(250)]
    public string FileCatCode { get; set; }

    [Column("FILE_PATH")]
    [StringLength(255)]
    public string FilePath { get; set; }

    [Column("UPDATED_BY")]
    public int? UpdatedBy { get; set; }
}
