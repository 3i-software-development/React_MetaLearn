using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("CRAWLER_SESSION_CONTENT_RESULT")]
public partial class CrawlerSessionContentResult
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("BOT_CODE")]
    public string BotCode { get; set; }

    [Column("SESSION_CODE")]
    [StringLength(255)]
    public string SessionCode { get; set; }

    [Column("LINK_POST")]
    public string LinkPost { get; set; }

    [Column("TEXT_CONTENT")]
    public string TextContent { get; set; }

    [Required]
    [Column("MEDIA_CRAWL")]
    public string MediaCrawl { get; set; }

    [Column("KEY_WORD")]
    public string KeyWord { get; set; }

    [Column("KEY_WORD_JSON")]
    public string KeyWordJson { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("CREATED_BY")]
    public string CreatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("UPDATED_BY")]
    public string UpdatedBy { get; set; }

    [Column("IS_DELETED")]
    public string IsDeleted { get; set; }

    [Column("DELETED_BY")]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }
}
