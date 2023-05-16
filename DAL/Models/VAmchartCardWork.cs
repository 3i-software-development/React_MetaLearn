using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
public partial class VAmchartCardWork
{
    [Column("ID")]
    public Guid? Id { get; set; }

    [Column("STATUS")]
    public string Status { get; set; }

    [Column("STATUS_COUNT")]
    public int? StatusCount { get; set; }

    [Column("LST_MONTH")]
    public int? LstMonth { get; set; }
}
