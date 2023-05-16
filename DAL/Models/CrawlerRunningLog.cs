using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("CRAWLER_RUNNING_LOG")]
public partial class CrawlerRunningLog
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("SESSION_CODE")]
    [StringLength(255)]
    public string SessionCode { get; set; }

    [Column("START_TIME")]
    public DateTime? StartTime { get; set; }

    [Column("END_TIME")]
    public DateTime? EndTime { get; set; }

    [Column("URL_SCAN_JSON")]
    public string UrlScanJson { get; set; }

    [Column("FILE_DOWNLOAD_JSON")]
    public string FileDownloadJson { get; set; }

    [Column("NUM_OF_FILE")]
    public int? NumOfFile { get; set; }

    [Column("FILE_RESULT_DATA")]
    public string FileResultData { get; set; }

    [Column("NUM_PASSCAP")]
    public int? NumPasscap { get; set; }

    [Column("USER_ID_RUNNING")]
    public string UserIdRunning { get; set; }

    [Column("IP")]
    public string Ip { get; set; }

    [Column("STATUS")]
    public string Status { get; set; }

    [Column("BOT_CODE")]
    public string BotCode { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("CREATED_BY")]
    public string CreatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("UPDATED_BY")]
    public string UpdatedBy { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("DELETED_BY")]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("TIME_SCAN")]
    public int? TimeScan { get; set; }

    [Column("KEY_WORD")]
    public string KeyWord { get; set; }

    [Column("FILE_SIZE_DOWNLOAD")]
    public int? FileSizeDownload { get; set; }
}
