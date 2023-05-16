using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("DISPATCHES_FILES_ACT")]
public partial class DispatchesFilesAct
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("PROCESS_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ProcessCode { get; set; }

    [Column("FILE_NAME")]
    public string FileName { get; set; }

    [Column("USER_ID")]
    [StringLength(255)]
    public string UserId { get; set; }

    [Column("SOURE")]
    public string Soure { get; set; }

    [Column("FOMART")]
    [StringLength(100)]
    public string Fomart { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }
}
