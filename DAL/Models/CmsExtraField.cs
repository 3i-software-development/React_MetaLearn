using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("cms_extra_fields")]
public partial class CmsExtraField
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Required]
    [Column("name")]
    [StringLength(255)]
    public string Name { get; set; }

    [Column("value")]
    public string Value { get; set; }

    [Column("type")]
    [StringLength(255)]
    public string Type { get; set; }

    [Column("group")]
    public int? Group { get; set; }

    [Column("published")]
    public bool? Published { get; set; }

    [Column("ordering")]
    public int? Ordering { get; set; }
}
