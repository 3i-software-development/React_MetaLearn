using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("OPERATION_ONLINE_SUPPORT_TRACKING")]
public partial class OperationOnlineSupportTracking
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("SVR_SESSION")]
    [StringLength(255)]
    [Unicode(false)]
    public string SvrSession { get; set; }

    [Column("CALLER")]
    [StringLength(255)]
    [Unicode(false)]
    public string Caller { get; set; }

    [Column("RECEIVER")]
    [StringLength(255)]
    [Unicode(false)]
    public string Receiver { get; set; }

    [Column("STARTED_TIME")]
    public DateTime? StartedTime { get; set; }

    [Column("ENDED_TIME")]
    public DateTime? EndedTime { get; set; }

    [Column("SVR_LOCATION")]
    [StringLength(255)]
    public string SvrLocation { get; set; }
}
