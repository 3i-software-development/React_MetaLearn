using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("WORK_OS_CARD_TRACKING_PROGRESS")]
public partial class WorkOsCardTrackingProgress
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("CARD_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string CardCode { get; set; }

    [Column("COMPLETED")]
    public int Completed { get; set; }

    [Column("COMPLETED_TIME")]
    public DateTime? CompletedTime { get; set; }
}
