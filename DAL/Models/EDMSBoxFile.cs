using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("EDMS_BOX_FILE")]
public partial class EdmsBoxFile
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("BOX_ID")]
    public int? BoxId { get; set; }

    [Column("FILE_ID")]
    public int? FileId { get; set; }
}
