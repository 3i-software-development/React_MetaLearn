using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("EDU_CATEGORY")]
public partial class EduCategory
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Required]
    [Column("NAME")]
    [StringLength(255)]
    public string Name { get; set; }

    [Column("ALIAS")]
    [StringLength(255)]
    public string Alias { get; set; }

    [Column("DESCRIPTION")]
    public string Description { get; set; }

    [Column("PARENT")]
    public int? Parent { get; set; }

    [Column("EXTRA_FIELDS_GROUP")]
    public int? ExtraFieldsGroup { get; set; }

    [Column("PUBLISHED")]
    public bool? Published { get; set; }

    [Column("ACCESS")]
    public int? Access { get; set; }

    [Column("ORDERING")]
    public int? Ordering { get; set; }

    [Column("IMAGE")]
    [StringLength(255)]
    public string Image { get; set; }

    [Column("PARAMS")]
    public string Params { get; set; }

    [Column("TRASH")]
    public bool? Trash { get; set; }

    [Column("PLUGINS")]
    public string Plugins { get; set; }

    [Column("LANGUAGE")]
    [StringLength(10)]
    [Unicode(false)]
    public string Language { get; set; }

    [Column("TEMPLATE")]
    [StringLength(255)]
    public string Template { get; set; }
}
