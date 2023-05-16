using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("cms_function_resource")]
public partial class CmsFunctionResource
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("functionId")]
    public int? FunctionId { get; set; }

    [Column("categoryId")]
    public int? CategoryId { get; set; }

    [Column("created", TypeName = "datetime")]
    public DateTime? Created { get; set; }

    [Column("created_by")]
    public int? CreatedBy { get; set; }

    [Column("modified", TypeName = "datetime")]
    public DateTime? Modified { get; set; }

    [Column("modified_by")]
    public int? ModifiedBy { get; set; }

    [Column("status")]
    public bool? Status { get; set; }
}
