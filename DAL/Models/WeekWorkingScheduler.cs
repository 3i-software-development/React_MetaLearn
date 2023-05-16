using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Model;

[Table("WEEK_WORKING_SCHEDULER")]
public partial class WeekWorkingScheduler
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("CONTENT")]
    public string Content { get; set; }

    [Column("COMPOSITION")]
    [StringLength(255)]
    public string Composition { get; set; }

    [Column("CHAIR")]
    [StringLength(50)]
    public string Chair { get; set; }

    [Column("ROOM")]
    [StringLength(255)]
    public string Room { get; set; }

    [Column("CREATED_TIME")]
    public DateTime CreatedTime { get; set; }

    [Column("TIME_START")]
    [StringLength(225)]
    public string TimeStart { get; set; }

    [Column("TIME_END")]
    [StringLength(225)]
    public string TimeEnd { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    public string CreatedBy { get; set; }
}
