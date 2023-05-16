using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("AD_ACTION_LOG")]
public partial class AdActionLog
{
    [Key]
    [Column("ACTION_LOG_ID")]
    public int ActionLogId { get; set; }

    [Column("LOG_LEVEL")]
    [StringLength(50)]
    public string LogLevel { get; set; }

    [Column("ACTION_LOG_APPLICATION")]
    [StringLength(500)]
    public string ActionLogApplication { get; set; }

    [Column("ACTION_LOG_HOST")]
    [StringLength(100)]
    public string ActionLogHost { get; set; }

    [Column("ACTION_LOG_PATH")]
    [StringLength(300)]
    public string ActionLogPath { get; set; }

    [Column("RESOURCE_NAME")]
    [StringLength(255)]
    public string ResourceName { get; set; }

    [Column("MESSAGE")]
    [StringLength(2000)]
    public string Message { get; set; }

    [Column("BROWSER")]
    [StringLength(300)]
    public string Browser { get; set; }

    [Column("IP_ADDRESS")]
    [StringLength(20)]
    public string IpAddress { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    public string CreatedBy { get; set; }

    [Column("CREATED_DATE")]
    public DateTime? CreatedDate { get; set; }

    [Column("TABLE_MODIFIED")]
    [StringLength(255)]
    public string TableModified { get; set; }

    [Column("DATA_NEW")]
    public string DataNew { get; set; }

    [Column("DATA_OLD")]
    public string DataOld { get; set; }

    [Column("AFFECTED_TO")]
    [StringLength(255)]
    public string AffectedTo { get; set; }
}
