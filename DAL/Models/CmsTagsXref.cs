using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("cms_tags_xref")]
public partial class CmsTagsXref
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("tag_id")]
    public int TagId { get; set; }

    [Column("item_id")]
    public int ItemId { get; set; }
}
