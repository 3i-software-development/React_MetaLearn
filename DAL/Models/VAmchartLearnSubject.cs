using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
public partial class VAmchartLearnSubject
{
    [Column("ID")]
    public Guid? Id { get; set; }

    [Column("MONTH_DATA")]
    public int? MonthData { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    public string CreatedBy { get; set; }

    [Column("USER_COUNT")]
    public int? UserCount { get; set; }

    [Column("LST_MONTH")]
    public int? LstMonth { get; set; }
}
