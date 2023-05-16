using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("AD_ACCESS_LOG")]
public partial class AdAccessLog
{
    [Key]
    [Column("ACCESS_LOG_ID", TypeName = "decimal(10, 0)")]
    public decimal AccessLogId { get; set; }

    [Column("ACCESS_LOG_CODE")]
    [StringLength(255)]
    public string AccessLogCode { get; set; }

    [Column("ACTION")]
    [StringLength(50)]
    public string Action { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(450)]
    public string Description { get; set; }

    [Column("USER_ID")]
    [StringLength(250)]
    public string UserId { get; set; }

    [Column("ACCESS_LOG_APPLICATION")]
    [StringLength(255)]
    public string AccessLogApplication { get; set; }

    [Column("ACCESS_DATE")]
    public DateTime? AccessDate { get; set; }

    [Column("IP_ADDRESS")]
    [StringLength(50)]
    public string IpAddress { get; set; }
}
