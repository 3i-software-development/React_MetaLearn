using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("cms_functions")]
public partial class CmsFunction
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("title")]
    [StringLength(500)]
    public string Title { get; set; }

    [Column("description")]
    [StringLength(1000)]
    public string Description { get; set; }

    [Column("created", TypeName = "datetime")]
    public DateTime? Created { get; set; }

    [Column("created_by")]
    public int? CreatedBy { get; set; }

    [Column("modified", TypeName = "datetime")]
    public DateTime? Modified { get; set; }

    [Column("modified_by")]
    public int? ModifiedBy { get; set; }

    [Column("flag")]
    public bool? Flag { get; set; }

    [Column("language")]
    [StringLength(10)]
    [Unicode(false)]
    public string Language { get; set; }
}
