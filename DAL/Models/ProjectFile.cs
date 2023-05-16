using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("PROJECT_FILE")]
public partial class ProjectFile
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("PROJECT_CODE")]
    [StringLength(100)]
    public string ProjectCode { get; set; }

    [Column("FILE_CODE")]
    [StringLength(100)]
    public string FileCode { get; set; }
}
