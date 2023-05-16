using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
public partial class VAmchartProject
{
    [Column("ID")]
    public Guid? Id { get; set; }

    [Column("STATUS")]
    [StringLength(255)]
    public string Status { get; set; }

    [Column("STATUS_COUNT")]
    public int? StatusCount { get; set; }

    [Column("LST_MONTH")]
    public int? LstMonth { get; set; }
}
