using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("EDMS_REQUEST_INPUT_FILE")]
public partial class EdmsRequestInputFile
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("REQ_ID")]
    public int? ReqId { get; set; }

    [Column("FILE_ID")]
    public int? FileId { get; set; }
}
