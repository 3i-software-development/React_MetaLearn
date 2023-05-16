using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("FILE_OBJECT_SHARE")]
public partial class FileObjectShare
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("OBJECT_TYPE")]
    [StringLength(255)]
    public string ObjectType { get; set; }

    [Column("OBJECT_CODE")]
    [StringLength(255)]
    public string ObjectCode { get; set; }

    [Column("FILE_NAME")]
    [StringLength(255)]
    public string FileName { get; set; }

    [Column("FILE_PATH")]
    [StringLength(255)]
    public string FilePath { get; set; }

    [Column("PERMISSION")]
    [StringLength(255)]
    public string Permission { get; set; }

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

    [Column("FILE_CODE")]
    [StringLength(255)]
    public string FileCode { get; set; }

    [Column("OBJECT_CODE_SHARED")]
    [StringLength(255)]
    public string ObjectCodeShared { get; set; }
}
