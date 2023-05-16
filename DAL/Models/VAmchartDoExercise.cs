using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
public partial class VAmchartDoExercise
{
    [Column("ID")]
    public Guid? Id { get; set; }

    [Column("MONTH_DATA")]
    public int? MonthData { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    public string CreatedBy { get; set; }

    [Column("RESULT")]
    public bool? Result { get; set; }

    [Column("TYPE_TRAINING")]
    [StringLength(255)]
    public string TypeTraining { get; set; }

    [Column("TYPE_COUNT")]
    public int? TypeCount { get; set; }

    [Column("LST_MONTH")]
    public int? LstMonth { get; set; }
}
