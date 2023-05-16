using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("cms_attachments")]
public partial class CmsAttachment
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("item_id")]
    public int ItemId { get; set; }

    [Column("file_name")]
    [StringLength(255)]
    public string FileName { get; set; }

    [Column("title")]
    [StringLength(255)]
    public string Title { get; set; }

    [Column("title_attribute")]
    [StringLength(255)]
    public string TitleAttribute { get; set; }

    [Column("hits")]
    public int? Hits { get; set; }

    [Column("file_url")]
    [StringLength(255)]
    public string FileUrl { get; set; }

    [Column("file_path")]
    [StringLength(255)]
    public string FilePath { get; set; }

    [Column("file_type")]
    [StringLength(255)]
    public string FileType { get; set; }
}
