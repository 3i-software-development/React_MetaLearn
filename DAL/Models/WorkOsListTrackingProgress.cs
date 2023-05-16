using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("WORK_OS_LIST_TRACKING_PROGRESS")]
public partial class WorkOsListTrackingProgress
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("LIST_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ListCode { get; set; }

    [Column("COMPLETED")]
    public int Completed { get; set; }

    [Column("COMPLETED_TIME")]
    public DateTime? CompletedTime { get; set; }
}
