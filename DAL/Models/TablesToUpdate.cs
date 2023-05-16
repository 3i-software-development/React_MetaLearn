using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("Tables_to_Update")]
public partial class TablesToUpdate
{
    [Column("Table_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string TableName { get; set; }

    [Column("Column_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string ColumnName { get; set; }

    [Column("recordsToUpdate")]
    public int? RecordsToUpdate { get; set; }
}
