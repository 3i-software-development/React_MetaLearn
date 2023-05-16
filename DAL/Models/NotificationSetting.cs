using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("NOTIFICATION_SETTING")]
public partial class NotificationSetting
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("NOTIFY_CODE")]
    [StringLength(255)]
    public string NotifyCode { get; set; }

    [Column("TITLE")]
    [StringLength(255)]
    public string Title { get; set; }

    [Column("BODY")]
    public string Body { get; set; }

    [Column("ACTIVE")]
    public bool? Active { get; set; }

    [Column("INTERVAL")]
    public int? Interval { get; set; }

    [Column("UNIT")]
    [StringLength(255)]
    public string Unit { get; set; }

    [Column("CREATE_BY")]
    [StringLength(255)]
    public string CreateBy { get; set; }

    [Column("CREATE_TIME")]
    public DateTime? CreateTime { get; set; }

    [Column("UPDATE_BY")]
    [StringLength(255)]
    public string UpdateBy { get; set; }

    [Column("UPDATE_TIME")]
    public DateTime? UpdateTime { get; set; }

    [Column("DELETE_BY")]
    [StringLength(255)]
    public string DeleteBy { get; set; }

    [Column("DELETE_TIME")]
    public DateTime? DeleteTime { get; set; }

    [Column("IS_DELETE")]
    public bool? IsDelete { get; set; }
}
