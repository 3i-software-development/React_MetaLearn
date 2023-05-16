using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("cms_setting")]
public partial class CmsSetting
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(255)]
    public string Name { get; set; }

    [Column("value")]
    public string Value { get; set; }

    [Column("published")]
    public bool? Published { get; set; }

    [Column("ordering")]
    public int? Ordering { get; set; }
}
