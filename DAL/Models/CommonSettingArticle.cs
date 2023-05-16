using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("COMMON_SETTING_ARTICLE")]
public partial class CommonSettingArticle
{
    [Column("SETTING_ID")]
    public int SettingId { get; set; }

    [Key]
    [Column("CODE_SET")]
    [StringLength(255)]
    public string CodeSet { get; set; }

    [Column("VALUE_SET")]
    [StringLength(255)]
    public string ValueSet { get; set; }

    [Column("GROUP")]
    [StringLength(255)]
    public string Group { get; set; }

    /// <summary>
    /// Asset_code ==null không được quản lý
    /// </summary>
    [Column("ASSET_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string AssetCode { get; set; }

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

    [Column("GROUP_NOTE")]
    [StringLength(255)]
    public string GroupNote { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("PRIORITY")]
    public int? Priority { get; set; }

    [Column("LOGO")]
    [StringLength(255)]
    [Unicode(false)]
    public string Logo { get; set; }

    [Column("TYPE")]
    [StringLength(255)]
    public string Type { get; set; }

    [Column("ARTICLE_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ArticleCode { get; set; }

    [StringLength(255)]
    public string Title { get; set; }
}
