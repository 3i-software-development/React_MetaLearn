using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("cms_items")]
public partial class CmsItem
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("title")]
    [StringLength(1000)]
    public string Title { get; set; }

    [Column("alias")]
    [StringLength(1000)]
    public string Alias { get; set; }

    [Column("cat_id")]
    public int? CatId { get; set; }

    [Column("published")]
    public bool? Published { get; set; }

    [Column("intro_text")]
    public string IntroText { get; set; }

    [Column("full_text")]
    public string FullText { get; set; }

    [Column("video")]
    [StringLength(500)]
    public string Video { get; set; }

    [Column("gallery")]
    [StringLength(255)]
    public string Gallery { get; set; }

    [Column("extra_fields")]
    public string ExtraFields { get; set; }

    [Column("extra_fields_search")]
    [StringLength(255)]
    public string ExtraFieldsSearch { get; set; }

    [Column("created", TypeName = "datetime")]
    public DateTime? Created { get; set; }

    [Column("created_by")]
    public int? CreatedBy { get; set; }

    [Column("created_by_alias")]
    [StringLength(255)]
    public string CreatedByAlias { get; set; }

    [Column("checked_out")]
    public int? CheckedOut { get; set; }

    [Column("checked_out_time", TypeName = "datetime")]
    public DateTime? CheckedOutTime { get; set; }

    [Column("modified", TypeName = "datetime")]
    public DateTime? Modified { get; set; }

    [Column("modified_by")]
    public int? ModifiedBy { get; set; }

    [Column("publish_up", TypeName = "datetime")]
    public DateTime? PublishUp { get; set; }

    [Column("publish_down", TypeName = "datetime")]
    public DateTime? PublishDown { get; set; }

    [Column("trash")]
    public bool? Trash { get; set; }

    [Column("access")]
    public int? Access { get; set; }

    [Column("ordering")]
    public int? Ordering { get; set; }

    [Column("featured")]
    public short? Featured { get; set; }

    [Column("featured_ordering")]
    public int? FeaturedOrdering { get; set; }

    [Column("image_caption")]
    [StringLength(500)]
    public string ImageCaption { get; set; }

    [Column("image_credits")]
    [StringLength(255)]
    public string ImageCredits { get; set; }

    [Column("video_caption")]
    [StringLength(500)]
    public string VideoCaption { get; set; }

    [Column("video_credits")]
    [StringLength(255)]
    public string VideoCredits { get; set; }

    [Column("hits")]
    public int? Hits { get; set; }

    [Column("params")]
    public string Params { get; set; }

    [Column("meta_desc")]
    [StringLength(1000)]
    public string MetaDesc { get; set; }

    [Column("meta_data")]
    [StringLength(1000)]
    public string MetaData { get; set; }

    [Column("meta_key")]
    [StringLength(1000)]
    public string MetaKey { get; set; }

    [Column("plugins")]
    public string Plugins { get; set; }

    [Column("language")]
    [StringLength(10)]
    [Unicode(false)]
    public string Language { get; set; }

    [Column("template")]
    [StringLength(255)]
    public string Template { get; set; }

    [Column("date_post", TypeName = "datetime")]
    public DateTime? DatePost { get; set; }

    [Column("LIST_USER_VIEW")]
    [Unicode(false)]
    public string ListUserView { get; set; }

    [Column("hash_tag")]
    public string HashTag { get; set; }

    [Column("blog_subject")]
    public string BlogSubject { get; set; }

    [Column("rate")]
    public int? Rate { get; set; }

    [Column("type")]
    public string Type { get; set; }
}
