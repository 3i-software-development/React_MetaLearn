using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("CRAWLER_JOB_SCHEDULE")]
public partial class CrawlerJobSchedule
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("JOB_SC_CODE")]
    public string JobScCode { get; set; }

    [Column("JOB_SC_TITLE")]
    public string JobScTitle { get; set; }

    [Column("JOB_SC_TYPE")]
    public string JobScType { get; set; }

    [Column("JOB_SC_RUN_TIME")]
    public string JobScRunTime { get; set; }

    [Column("JOB_SC_DESC")]
    public string JobScDesc { get; set; }

    [Column("STATUS")]
    public string Status { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(50)]
    public string UpdatedBy { get; set; }

    [Column("UPDATE_TIME")]
    public DateTime? UpdateTime { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("DELETED_BY")]
    [StringLength(50)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("BOT_CODE")]
    [StringLength(50)]
    public string BotCode { get; set; }
}
