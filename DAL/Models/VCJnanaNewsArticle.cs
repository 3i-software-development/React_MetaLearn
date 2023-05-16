using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("VC_JNANA_NEWS_ARTICLE")]
public partial class VcJnanaNewsArticle
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("ARTICLE_CODE")]
    [StringLength(250)]
    public string ArticleCode { get; set; }

    [Column("ARTICLE_TITLE")]
    [StringLength(1000)]
    public string ArticleTitle { get; set; }

    [Column("CREATED_BY")]
    public int? CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime CreatedTime { get; set; }

    [Column("UPDATE_BY")]
    public int? UpdateBy { get; set; }

    [Column("UPDATE_TIME")]
    public DateTime? UpdateTime { get; set; }

    [Column("ARTICLE_STATUS")]
    public int ArticleStatus { get; set; }

    [Column("ARTICLE_AVARTA")]
    [StringLength(1000)]
    public string ArticleAvarta { get; set; }

    [Column("CAT_CODE")]
    [StringLength(250)]
    public string CatCode { get; set; }

    [Column("ARTICLE_CONTENT")]
    [StringLength(1000)]
    public string ArticleContent { get; set; }

    [Column("ARTILE_ORDER")]
    public int? ArtileOrder { get; set; }
}
