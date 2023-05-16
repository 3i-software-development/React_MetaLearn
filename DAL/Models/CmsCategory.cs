using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("cms_categories")]
public partial class CmsCategory
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Required]
    [Column("name")]
    [StringLength(255)]
    public string Name { get; set; }

    [Column("alias")]
    [StringLength(255)]
    public string Alias { get; set; }

    [Column("description")]
    [StringLength(4000)]
    public string Description { get; set; }

    [Column("parent")]
    public int? Parent { get; set; }

    [Column("extra_fields_group")]
    public int? ExtraFieldsGroup { get; set; }

    [Column("published")]
    public bool? Published { get; set; }

    [Column("access")]
    public int? Access { get; set; }

    [Column("ordering")]
    public int? Ordering { get; set; }

    [Column("image")]
    [StringLength(255)]
    public string Image { get; set; }

    [Column("params")]
    public string Params { get; set; }

    [Column("trash")]
    public bool? Trash { get; set; }

    [Column("plugins")]
    public string Plugins { get; set; }

    [Column("language")]
    [StringLength(10)]
    [Unicode(false)]
    public string Language { get; set; }

    [Column("template")]
    [StringLength(255)]
    public string Template { get; set; }
}
