using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("cms_rating")]
public partial class CmsRating
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("item_id")]
    public int ItemId { get; set; }

    [Column("rating_sum")]
    public int? RatingSum { get; set; }

    [Column("rating_count")]
    public int? RatingCount { get; set; }

    [Column("lastip")]
    [StringLength(50)]
    [Unicode(false)]
    public string Lastip { get; set; }
}
