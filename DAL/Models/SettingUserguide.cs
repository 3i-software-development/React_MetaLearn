using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Keyless]
[Table("SETTING_USERGUIDE")]
public partial class SettingUserguide
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("HELP_ID")]
    [StringLength(255)]
    public string HelpId { get; set; }

    [Column("ARTICLE_ID")]
    [StringLength(255)]
    public string ArticleId { get; set; }

    [Column("BOOK_MARK")]
    [StringLength(255)]
    public string BookMark { get; set; }

    [Column("DESCRIPTION")]
    public string Description { get; set; }

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
