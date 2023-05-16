using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("cms_comments")]
public partial class CmsComment
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("item_id")]
    public int ItemId { get; set; }

    [Column("user_id")]
    public int? UserId { get; set; }

    [Column("user_name")]
    [StringLength(255)]
    public string UserName { get; set; }

    [Column("comment_date", TypeName = "datetime")]
    public DateTime? CommentDate { get; set; }

    [Column("comment_text")]
    public string CommentText { get; set; }

    [Column("comment_email")]
    [StringLength(255)]
    public string CommentEmail { get; set; }

    [Column("comment_url")]
    [StringLength(255)]
    public string CommentUrl { get; set; }

    [Column("published")]
    public bool? Published { get; set; }

    [Column("comment_title")]
    [StringLength(1000)]
    public string CommentTitle { get; set; }
}
