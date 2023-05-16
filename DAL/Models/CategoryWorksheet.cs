using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("CATEGORY_WORKSHEET")]
public partial class CategoryWorksheet
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("CATEGORY_ID")]
    public int CategoryId { get; set; }

    [Column("WORKSHEET_ID")]
    public int WorksheetId { get; set; }

    [Column("STATUS")]
    public bool? Status { get; set; }

    [Column("ORDER")]
    public int? Order { get; set; }
}
