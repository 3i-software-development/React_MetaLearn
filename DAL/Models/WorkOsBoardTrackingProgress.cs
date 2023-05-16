using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("WORK_OS_BOARD_TRACKING_PROGRESS")]
public partial class WorkOsBoardTrackingProgress
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("BOARD_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string BoardCode { get; set; }

    [Column("COMPLETED")]
    public int Completed { get; set; }

    [Column("COMPLETED_TIME")]
    public DateTime? CompletedTime { get; set; }
}
