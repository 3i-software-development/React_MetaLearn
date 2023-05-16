using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("WORK_EVENT_CAT")]
public partial class WorkEventCat
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("EVENT_CAT_CODE")]
    [StringLength(255)]
    public string EventCatCode { get; set; }

    [Column("EVENT_TITLE")]
    [StringLength(255)]
    public string EventTitle { get; set; }

    [Column("DATETIME_EVENT")]
    public DateTime DatetimeEvent { get; set; }

    [Column("FRAME_TIME")]
    [StringLength(255)]
    public string FrameTime { get; set; }

    [Column("FORMAT_SETTING")]
    [StringLength(255)]
    public string FormatSetting { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(50)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(50)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("FLAG_DELETE")]
    public bool FlagDelete { get; set; }
}
