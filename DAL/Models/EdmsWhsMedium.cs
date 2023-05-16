using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("EDMS_WHS_MEDIA")]
public partial class EdmsWhsMedium
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("FILE_CODE")]
    [StringLength(255)]
    public string FileCode { get; set; }

    [Column("FILE_NAME")]
    [StringLength(255)]
    public string FileName { get; set; }

    [Column("FILE_PATH")]
    [StringLength(255)]
    public string FilePath { get; set; }

    [Column("FILE_EXT")]
    [StringLength(255)]
    public string FileExt { get; set; }

    [Column("FILE_SITE")]
    [StringLength(255)]
    public string FileSite { get; set; }

    [Column("NOTE")]
    [StringLength(255)]
    public string Note { get; set; }
}
