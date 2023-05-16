using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("EDMS_RECEIPT_INPUT_FILE")]
public partial class EdmsReceiptInputFile
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("REC_ID")]
    public int? RecId { get; set; }

    [Column("FILE_ID")]
    public int? FileId { get; set; }
}
