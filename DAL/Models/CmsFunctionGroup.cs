using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("cms_function_group")]
public partial class CmsFunctionGroup
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("functionId")]
    public int? FunctionId { get; set; }

    [Column("groupId")]
    public int? GroupId { get; set; }

    [Column("view")]
    public bool? View { get; set; }

    [Column("add")]
    public bool? Add { get; set; }

    [Column("update")]
    public bool? Update { get; set; }

    [Column("delete")]
    public bool? Delete { get; set; }

    [Column("full")]
    public bool? Full { get; set; }

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
