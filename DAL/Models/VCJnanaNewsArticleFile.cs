using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("VC_JNANA_NEWS_ARTICLE_FILE")]
public partial class VcJnanaNewsArticleFile
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("FILE_CODE")]
    [StringLength(250)]
    public string FileCode { get; set; }

    [Column("CREATED_BY")]
    public int? CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("ARTICLE_CODE")]
    [StringLength(250)]
    public string ArticleCode { get; set; }
}
