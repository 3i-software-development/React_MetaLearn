using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("PO_SUP_FILE")]
public partial class PoSupFile
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("FILE_NAME")]
    [StringLength(255)]
    [Unicode(false)]
    public string FileName { get; set; }

    [Column("FILE_PATH")]
    [StringLength(255)]
    [Unicode(false)]
    public string FilePath { get; set; }

    [Column("FILE_TYPE")]
    [StringLength(255)]
    [Unicode(false)]
    public string FileType { get; set; }

    [Column("NOTED")]
    public string Noted { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }
}
