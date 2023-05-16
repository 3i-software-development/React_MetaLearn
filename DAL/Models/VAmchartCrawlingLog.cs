using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
public partial class VAmchartCrawlingLog
{
    [Column("ID")]
    public Guid? Id { get; set; }

    [Column("SUM_PASSCAP")]
    public int? SumPasscap { get; set; }

    [Column("SUM_TIME_SCAN")]
    public int? SumTimeScan { get; set; }

    [Column("SUM_URL")]
    public int? SumUrl { get; set; }

    [Column("SUM_FILE")]
    public int? SumFile { get; set; }

    [Column("LST_DAY")]
    public int? LstDay { get; set; }
}
