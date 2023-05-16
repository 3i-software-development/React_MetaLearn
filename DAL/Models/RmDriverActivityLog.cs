using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Keyless]
[Table("RM_DRIVER_ACTIVITY_LOG")]
public partial class RmDriverActivityLog
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("USER_NAME")]
    [StringLength(100)]
    public string UserName { get; set; }

    [Column("CDATA_JSON")]
    public string CdataJson { get; set; }

    [Column("UPDATE_TIME")]
    public DateTime? UpdateTime { get; set; }

    [Column("SYS_DATE")]
    public DateTime? SysDate { get; set; }

    [Column("CHANEL")]
    [StringLength(100)]
    public string Chanel { get; set; }

    [Column("NODE_GIS")]
    public string NodeGis { get; set; }

    [Column("DRIVER_ID")]
    public int? DriverId { get; set; }
}
