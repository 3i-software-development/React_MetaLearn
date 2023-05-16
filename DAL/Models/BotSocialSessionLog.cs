using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("BOT_SOCIAL_SESSION_LOG")]
public partial class BotSocialSessionLog
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("BOT_SESSION")]
    public string BotSession { get; set; }

    [Column("START_TIME")]
    public DateTime? StartTime { get; set; }

    [Column("END_TIME")]
    public DateTime? EndTime { get; set; }

    [Column("STATVS")]
    public string Statvs { get; set; }

    [Column("BOT_SOCIAL_CODE")]
    [StringLength(50)]
    public string BotSocialCode { get; set; }

    [Column("FILE_RESULTS")]
    public string FileResults { get; set; }

    [Column("RUNING_TYPE")]
    [StringLength(50)]
    public string RuningType { get; set; }

    [Column("BOT_SESSION_RESULT")]
    public string BotSessionResult { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    public string CreatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(50)]
    public string UpdatedBy { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("DELETED_BY")]
    [StringLength(50)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }
}
