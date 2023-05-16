using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("CRAWLER_BOT_MANAGEMENT")]
public partial class CrawlerBotManagement
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("URL")]
    public string Url { get; set; }

    [Column("BOT_SESSION_CODE")]
    [StringLength(255)]
    public string BotSessionCode { get; set; }

    [Column("IDENTIFIER_BOT")]
    public string IdentifierBot { get; set; }

    [Column("LIST_KEY_WORD")]
    [StringLength(255)]
    public string ListKeyWord { get; set; }

    [Column("DATA_STORAGE_PATH")]
    [StringLength(255)]
    public string DataStoragePath { get; set; }

    [Column("CONFIG_SELECTOR_JSON")]
    public string ConfigSelectorJson { get; set; }

    [Column("ROBOT_CODE")]
    [StringLength(255)]
    public string RobotCode { get; set; }

    [Column("DEEP_SCAN")]
    public int? DeepScan { get; set; }

    [Column("IS_DOWNLOAD_FILE")]
    public bool? IsDownloadFile { get; set; }

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
